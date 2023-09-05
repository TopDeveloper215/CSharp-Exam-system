using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;
using System.IO;
using System.Xml;

namespace Simulator
{

    public class Question
    {

        public Question()
        {
            SectionTitle = "";
            QuestionNumber = 0;
            QuestionText = "";
            QuestionImageBase64 = null;
            QuestionOptions = new Dictionary<char, string>();
            QuestionAnswer = "";
            AnswerExplanation = "";
        }


        //Properties
        public string SectionTitle { get; set; }

        public int QuestionNumber { get; set; }

        public string QuestionText { get; set; }

        public string QuestionImageBase64 { get; set; }

        public Dictionary<char, string> QuestionOptions { get; set; }

        public string QuestionAnswer { get; set; }

        public string AnswerExplanation { get; set; }

        public static List<Question> GetQuestions(string ExamFilePath)
        {
            string XMLinText = EncryptDecrypt.Decrypt(File.ReadAllText(ExamFilePath));
            
            List<Question> result = new List<Question>();
            string[] sections = GetSections(Properties.Settings.Default.SelectedSections);
            XPathDocument doc;
            using (TextReader tr = new StringReader(XMLinText))
            {
                doc = new XPathDocument(tr);
            }

            XPathNavigator nav = doc.CreateNavigator();
            XmlNamespaceManager nm = new XmlNamespaceManager(nav.NameTable);
            // Compile a standard XPath expression
            XPathExpression expr;
            XPathNodeIterator iterator;
            string version = "";
            expr = nav.Compile("//FileVersion");
            iterator = nav.Select(expr);
            while(iterator.MoveNext())
            {
                version = iterator.Current.Value;
            }
            for (int i = 0; i < sections.Length; i++)
            {
                expr = nav.Compile("//Section[@Title='" + sections[i] + "']/Question");
                iterator = nav.Select(expr);
                // Iterate on the node set
                while (iterator.MoveNext())
                {
                    Question ques = new Question();
                    ques.SectionTitle = sections[i];
                    ques.QuestionNumber = Convert.ToInt32(iterator.Current.GetAttribute("No", nm.DefaultNamespace));
                    Dictionary<char, string> options = new Dictionary<char, string>();
                    XPathNodeIterator iter = iterator.Current.SelectChildren(XPathNodeType.Element);
                    while (iter.MoveNext())
                    {
                        if (iter.Current.LocalName == "Text")
                        {
                            ques.QuestionText = iter.Current.Value;
                        }
                        else if (iter.Current.LocalName == "Image")
                        {
                            ques.QuestionImageBase64 = iter.Current.Value;
                        }
                        else if (iter.Current.LocalName == "Answer")
                        {
                            ques.QuestionAnswer = iter.Current.Value;
                        }
                        if (iter.Current.LocalName == "Options")
                        {
                            XPathNodeIterator ite = iter.Current.SelectChildren(XPathNodeType.Element);
                            while (ite.MoveNext())
                            {
                                char option;
                                string optionText;
                                string tempp = ite.Current.GetAttribute("Title", nm.DefaultNamespace);
                                option = Convert.ToChar(tempp);
                                optionText = ite.Current.Value;
                                options.Add(option, optionText);
                            }
                            ques.QuestionOptions = options;
                        }

                        if (iter.Current.LocalName == "AnswerExplanation")
                            ques.AnswerExplanation = iter.Current.Value;
                    }
                    result.Add(ques);
                }
            }
            return result;
        }


        public static string[] GetSections(System.Collections.Specialized.StringCollection sections)
        {
            List<string> redactedSections = new List<string>();
            try
            {
                foreach (var section in sections)
                {
                    if (!string.IsNullOrWhiteSpace(section))
                    {
                        redactedSections.Add(section);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                GlobalPathVariables.WriteError(ex, "Exam UI");
            }
            return redactedSections.ToArray();
        }
        

    }


    public class GlobalPathVariables
    {
        public static string errorLogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error Log.log");
        public static string UserFileDirectoryPath
        {
            get;
            set;
        }
        
        public static string GetXmlFilePath(string examFilesFolder)
        {
            string[] temp = Directory.GetFiles(examFilesFolder, "*.xml", SearchOption.TopDirectoryOnly);
            if (temp.Length > 0)
            {
                return temp[0];
            }
            else
            {
                return null;
            }
        }
        public static void WriteError(Exception exc, string sender)
        {
            //Check if log file exists, else create it
            if (!File.Exists(GlobalPathVariables.errorLogPath))
            {
                File.Create(GlobalPathVariables.errorLogPath);
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(GlobalPathVariables.errorLogPath))
                {
                    sw.WriteLine("[" + DateTime.UtcNow.Date + " " + DateTime.UtcNow.ToShortTimeString() + " UTC]: An " + exc.GetType().ToString() + " exception occured in " + sender + "; Message: " + exc.Message + "; InnerException: " + exc.InnerException);
                    sw.WriteLine("");
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("An error occured:  \n" + e.Message);
            }
        }
    }
}
