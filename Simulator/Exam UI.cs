using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using System.IO;
using System.Runtime.InteropServices;



namespace Simulator
{
    public partial class Exam_UI : Form
    {
        //Global Variables
        List<Question> questions;
        string[] givenAnswers;
        int currentQuestionIndex;
        int timeLeft;
        string filename;
        string filePath;
        int totalSeconds;
        string examCode;
        string ExamTitle = string.Empty;
        string userLastOpt = string.Empty;
        RichTextBox rtb_answerExplanation = new RichTextBox();

        public enum NavigationOption
        {
        	Next,
        	Previous,
        	Begin,
        	End
        };
        
        public Exam_UI(string fileName, string filePath)
        {
            InitializeComponent();
            timeLeft = Properties.Settings.Default.TimerValue * 60;
            this.filename = fileName;
            this.filePath = filePath;

            rtb_answerExplanation.Name = "rtb_AnsExp";
            rtb_answerExplanation.Multiline = true;
            rtb_answerExplanation.ScrollBars = RichTextBoxScrollBars.None;
            rtb_answerExplanation.Visible = false;
            rtb_answerExplanation.ReadOnly = true;
            rtb_answerExplanation.Dock = DockStyle.Fill;
            rtb_answerExplanation.ForeColor = Color.Green;
            rtb_answerExplanation.ContentsResized += richTextBox_ContentsResized;
        }

        private void Exam_UI_Load(object sender, EventArgs e)
        {
            string XMLinText = EncryptDecrypt.Decrypt(File.ReadAllText(filePath));

            try
            {
                XPathDocument doc;
                using (TextReader tr = new StringReader(XMLinText))
                {
                    doc = new XPathDocument(tr);
                }
                XPathNavigator nav = doc.CreateNavigator();
                XPathExpression expr;
                expr = nav.Compile("//ExamTitle");
                XPathNodeIterator iterator = nav.Select(expr);
                while (iterator.MoveNext())
                {
                    this.ExamTitle = lbl_exam_title.Text = iterator.Current.Value;
                }
                expr = nav.Compile("//ExamCode");
                iterator = nav.Select(expr);
                while (iterator.MoveNext())
                {
                    this.examCode = lbl_exam_code.Text = iterator.Current.Value;
                }
                expr = nav.Compile("//ExamInstructions");
                iterator = nav.Select(expr);
                while (iterator.MoveNext())
                {
                    lbl_exam_instructions.Text = iterator.Current.Value;
                }
                expr = nav.Compile("//PassingScore");
                iterator = nav.Select(expr);
                while (iterator.MoveNext())
                {
                    Properties.Settings.Default.RequiredScore = Convert.ToInt32(iterator.Current.Value);
                }
                Properties.Settings.Default.Save();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Sorry, the selected exam was corrupted, please re-add the exam before retrying.", "Exam Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalPathVariables.WriteError(ex, this.Name);
                this.Close();
            }

            questions = new List<Question>();
            questions = Question.GetQuestions(filePath);
            givenAnswers = new string[questions.Count];
        }
        
        private void btn_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult result = MessageBox.Show("Exam paused, Click 'OK' to continue.", "Paused", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                timer.Start(); 
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            DisplayQuestion(NavigationOption.End);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            DisplayQuestion(NavigationOption.Next);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            DisplayQuestion(NavigationOption.Previous);
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            lbl_exam_code.Visible = false;
            lbl_exam_instructions.Visible = false;
            lbl_exam_title.Visible = false;
            btn_begin.Enabled = false;
            btn_begin.Visible = false;
            btn_end.Enabled = true;
            btn_end.Visible = true;
            btn_pause.Enabled = true;
            btn_pause.Visible = true;
            btn_previous.Enabled = false;
            btn_previous.Visible = true;
            btn_next.Enabled = true;
            btn_next.Visible = true;
            btn_show_answer.Visible = true;
            btn_show_answer.Enabled = true;
            lbl_elapsed_time.Visible = true;
            lbl_elapsed_time.Enabled = true;
            label1.Enabled = true;
            label1.Visible = true;
            timer.Start();
            DisplayQuestion(NavigationOption.Begin);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                double x = timeLeft / 3600;
                double hours = Math.Floor(x);
                double y = (timeLeft % 3600) / 60;
                double minutes = Math.Floor(y);
                double seconds = timeLeft % 60;
                string temp = String.Format("{0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));
                lbl_elapsed_time.Text = temp;
                this.totalSeconds += 1;
            }
            else
            {
                timer.Stop();
                lbl_elapsed_time.Text = "Time's up!";
                MessageBox.Show("Your time ran out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_end_Click(btn_end, null);
            }
        }

        public void DisplayQuestion(NavigationOption option)
        {
            
            if (btn_show_answer.Text == "Hide Answer") { btn_show_answer.PerformClick(); }


            lbl_question_number.Visible = true;
            rtb_answerExplanation.Visible = false;
            lbl_section_title.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txt_question.Visible = true;
            
            
            if (option == NavigationOption.Begin)
            {

                currentQuestionIndex = 0;
                Question question = questions.ElementAt(currentQuestionIndex);
                lbl_question_number.Text = question.QuestionNumber.ToString();
                lbl_section_title.Text = question.SectionTitle;
                txt_question.Rtf = question.QuestionText;
                rtb_answerExplanation.Text = GetTextFromRTF(question.AnswerExplanation);
                
                for (int i = 0; i < question.QuestionOptions.Count; i++)
                {
                    OptionControl oc = new OptionControl();
                    oc.OptionLetter = question.QuestionOptions.ElementAt(i).Key;
                    oc.OptionText = question.QuestionOptions.ElementAt(i).Value;
                    oc.Location = new Point(51, 464 + (i * 22));
                    oc.Dock = DockStyle.Top;
                    pan_display.Controls.Add(oc);

                }
                pan_display.Controls.Add(new Label() { Height = pnl_bottom.Height });

                if ((Exam_Settings.ExamType.SelectedSections.ToString() == Properties.Settings.Default.ExamType && questions.Count == 1) || (Exam_Settings.ExamType.SelectedNumber.ToString() == Properties.Settings.Default.ExamType && Properties.Settings.Default.NumOfQuestions == 1))
                    btn_next.Enabled = false;
                this.Invalidate();
            }

            if (option == NavigationOption.Previous)
            {
                //determine the selected answer for this question and save it before moving to the previous question
                for (int j = pan_display.Controls.OfType<OptionControl>().Count() - 1; j >= 0; --j)
                {
                    var ctrls = pan_display.Controls.OfType<OptionControl>();
                    var ctrl = ctrls.ElementAt(j);
                    if (ctrl.IsChecked)
                    {
                        if ((givenAnswers[currentQuestionIndex] == null) || !givenAnswers[currentQuestionIndex].Contains("," + (ctrl.OptionLetter) + ","))
                        {
                            givenAnswers[currentQuestionIndex] = "," + (ctrl.OptionLetter) + ",";
                        }
                    }
                    pan_display.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
                if (currentQuestionIndex > 0)
                {
                    currentQuestionIndex -= 1;
                    Question question = questions.ElementAt(currentQuestionIndex);
                    lbl_question_number.Text = question.QuestionNumber.ToString();
                    lbl_section_title.Text = question.SectionTitle;
                    txt_question.Rtf = question.QuestionText;
                    rtb_answerExplanation.Text = GetTextFromRTF(question.AnswerExplanation);
                    
                    for (int i = 0; i < question.QuestionOptions.Count; i++)
                    {
                        OptionControl oc = new OptionControl();
                        oc.OptionLetter = question.QuestionOptions.ElementAt(i).Key;
                        oc.OptionText = question.QuestionOptions.ElementAt(i).Value;
                        oc.Location = new Point(51, 464 + (i * 22));
                        oc.Dock = DockStyle.Top;
                        //AssignEventsTo_RichTextBoxes();
                        pan_display.Controls.Add(oc);
                        if (givenAnswers[currentQuestionIndex] != null && givenAnswers[currentQuestionIndex].Contains(","+question.QuestionOptions.ElementAt(i).Key.ToString()+ ","))
                            oc.IsChecked = true;

                        pan_display.Controls.Add(oc);
                    }
                    if (currentQuestionIndex == 0)
                    {
                        btn_previous.Enabled = false;
                    }
                    btn_next.Enabled = true;
                }
            }

            if (option == NavigationOption.Next)
            {

                //determine the selected answer for this question and save it before moving to the next question
                for (int j = pan_display.Controls.OfType<OptionControl>().Count() - 1; j >= 0; --j)
                {
                    var ctrls = pan_display.Controls.OfType<OptionControl>();
                    var ctrl = ctrls.ElementAt(j);
                    if (ctrl.IsChecked)
                    {
                        if((givenAnswers[currentQuestionIndex]==null) || !givenAnswers[currentQuestionIndex].Contains("," + (ctrl.OptionLetter) + ","))
                        {
                            givenAnswers[currentQuestionIndex] += "," + (ctrl.OptionLetter) + ",";
                        }
                    }
                    pan_display.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
                currentQuestionIndex += 1;
                Question question = questions.ElementAt(currentQuestionIndex);
                lbl_question_number.Text = question.QuestionNumber.ToString();
                lbl_section_title.Text = question.SectionTitle;
                txt_question.Rtf = question.QuestionText;
                rtb_answerExplanation.Text = GetTextFromRTF(question.AnswerExplanation);
                
                for (int i = 0; i < question.QuestionOptions.Count; i++)
                {
                    OptionControl oc = new OptionControl();
                    oc.OptionLetter = question.QuestionOptions.ElementAt(i).Key;
                    oc.OptionText = question.QuestionOptions.ElementAt(i).Value;
                    oc.Location = new Point(51, 464 + (i * 22));
                    oc.Dock = DockStyle.Top;
                    //AssignEventsTo_RichTextBoxes();
                    pan_display.Controls.Add(oc);
                    if (givenAnswers[currentQuestionIndex] != null && givenAnswers[currentQuestionIndex].Contains("," + question.QuestionOptions.ElementAt(i).Key.ToString() + ","))
                        oc.IsChecked = true;

                    pan_display.Controls.Add(oc);
                }
                btn_previous.Enabled = true;
                if ((Exam_Settings.ExamType.SelectedSections.ToString() == Properties.Settings.Default.ExamType && currentQuestionIndex == questions.Count - 1) || (Exam_Settings.ExamType.SelectedNumber.ToString() == Properties.Settings.Default.ExamType && currentQuestionIndex == Properties.Settings.Default.NumOfQuestions))
                {
                    btn_next.Enabled = false;
                }

                this.Invalidate();
            }           
 
            if (option == NavigationOption.End)
            {
                //determine the selected answer for this question and save it before ending the exam
                for (int j = pan_display.Controls.OfType<OptionControl>().Count() - 1; j >= 0; --j)
                {
                    var ctrls = pan_display.Controls.OfType<OptionControl>();
                    var ctrl = ctrls.ElementAt(j);
                    if (ctrl.IsChecked)
                    {
                        givenAnswers[currentQuestionIndex] += ","+(ctrl.OptionLetter)+",";
                    }
                    pan_display.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
                //Stop the countdown timer
                timer.Stop();
                //determine how many answers are correct and get section details
                int numOfCorrect = 0;
                int total;
                Dictionary<string, int> totalQuestionsPerSection = new Dictionary<string, int>();
                Dictionary<string, int> rightQuestionsPerSection = new Dictionary<string, int>();
                for (int i = 0; i < questions.Count; i++)
                {
                    if (totalQuestionsPerSection.ContainsKey(questions.ElementAt(i).SectionTitle))
                    {
                        totalQuestionsPerSection[questions.ElementAt(i).SectionTitle] += 1;
                    }
                    else
                    {
                        totalQuestionsPerSection.Add(questions.ElementAt(i).SectionTitle, 1);
                    }
                    if (rightQuestionsPerSection.ContainsKey(questions.ElementAt(i).SectionTitle))
                    {
                        bool Correct = true;
                        if (givenAnswers[i] != null)
                        {
                            string[] selectedAnswers = givenAnswers[i].Split(',');
                            foreach (string ans in selectedAnswers)
                            {
                                if (ans.Trim() == "") continue;
                                if (!questions.ElementAt(i).QuestionAnswer.Contains("," + ans + ","))
                                {
                                    Correct = false;
                                }
                            }
                        }
                        else Correct = false;

                        if (Correct)
                        {
                            rightQuestionsPerSection[questions.ElementAt(i).SectionTitle] += 1;
                            numOfCorrect += 1;
                        }
                    }
                    else
                    {
                        bool Correct = true;
                        if (givenAnswers[i] != null)
                        {
                            string[] selectedAnswers = givenAnswers[i].Split(',');
                            foreach (string ans in selectedAnswers)
                            {
                                if (ans.Trim() == "") continue;
                                if (!questions.ElementAt(i).QuestionAnswer.Contains("," + ans + ","))
                                {
                                    Correct = false;
                                }
                            }
                        }
                        else Correct = false;

                        rightQuestionsPerSection.Add(questions.ElementAt(i).SectionTitle, 0);
                        if (Correct)
                        {
                            rightQuestionsPerSection[questions.ElementAt(i).SectionTitle] += 1;
                            numOfCorrect += 1;
                        }
                    }
                }
                total = questions.Count;
                Score_Sheet scs;
                if (Properties.Settings.Default.ExamType == Exam_Settings.ExamType.SelectedNumber.ToString())
                {
                    scs = new Score_Sheet(ExamTitle, totalSeconds / 60.0, examCode, ((numOfCorrect * 1000) / Properties.Settings.Default.NumOfQuestions), totalQuestionsPerSection, rightQuestionsPerSection);
                }
                else
                {
                    scs = new Score_Sheet(ExamTitle, totalSeconds / 60.0, examCode, ((numOfCorrect * 1000) / total), totalQuestionsPerSection, rightQuestionsPerSection);
                }
                this.Hide();
                scs.ShowDialog();
                this.Close();
            }
        }
        
        private void btn_show_answer_Click(object sender, EventArgs e)
        {
            
            if (btn_show_answer.Text == "Show Answer")
            {
                foreach(OptionControl oc in pan_display.Controls.OfType<OptionControl>())
                {
                    //user selected option:
                    if (oc.IsChecked)
                    {
                        userLastOpt = oc.OptionLetter.ToString();
                        if (!questions[currentQuestionIndex].QuestionAnswer.Contains("," + userLastOpt + ","))
                        {
                            oc.ForeColor = Color.Red;
                            foreach(Control c in oc.Controls) { c.ForeColor = Color.Red; }
                        }
                    }
                    if (questions[currentQuestionIndex].QuestionAnswer.Contains(","+ oc.OptionLetter+","))
                    {
                        oc.ForeColor = Color.Green;
                        foreach (Control c in oc.Controls) { c.ForeColor = Color.Green; }
                    }
                }
                btn_show_answer.Text = "Hide Answer";
                rtb_answerExplanation.Visible = true;
                pan_display.Controls.Add(rtb_answerExplanation);
                rtb_answerExplanation.Height += pnl_bottom.Height;

            }
            else
            {
                userLastOpt = string.Empty;
                btn_show_answer.Text = "Show Answer";
                rtb_answerExplanation.Visible = false;
                pan_display.Controls.Remove(rtb_answerExplanation);

                foreach (OptionControl oc in pan_display.Controls.OfType<OptionControl>())
                {
                    oc.ForeColor = Color.Black;
                    foreach (Control c in oc.Controls) { c.ForeColor = Color.Black; }
                }
            }
        }

        private void richTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            //increasing size of rich textbox:
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 15;
        }

        private void AnsExpRTB_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            //increasing size of rich textbox:
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 50;
        }


        private string GetTextFromRTF(string RTF)
        {
            RichTextBox tempRTB = new RichTextBox();
            tempRTB.Rtf = RTF;
            string result = tempRTB.Text;
            tempRTB.Dispose();

            return result;
        }

        private void ClearOldOptions()
        {
            foreach (OptionControl oc in Common.GetAllChildren(this).OfType<OptionControl>())
            {
                oc.Dispose();
                pan_display.Controls.Remove(oc);
            }
        }

        public void hideHorizontalScrollBar(ref TableLayoutPanel pan)
        {
            if (!pan.HorizontalScroll.Visible)
                return;
            pan.Padding = new Padding(0, 0, 0, 0);
            while (!!pan.HorizontalScroll.Visible || pan.Padding.Right >= SystemInformation.VerticalScrollBarWidth * 2)
                pan.Padding = new Padding(0, 0, pan.Padding.Right + 1, 0);
        }
    }
}
