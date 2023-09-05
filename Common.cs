using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

public static class Common
{
    public static string AppFileVersion = "1.00.002";
    
    public static bool VersionAllowed(string version)
    {
        int FileVer = int.Parse(string.Join("", version.Split('.')));
        int AppFileVer = int.Parse(string.Join("", AppFileVersion.Split('.')));
        if (AppFileVer != FileVer)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static string GetVersionFromFile(string ExamFilePath)
    {
        string XMLinText = EncryptDecrypt.Decrypt(File.ReadAllText(ExamFilePath));
        
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
        while (iterator.MoveNext())
        {
            version = iterator.Current.Value;
        }
        return version;
    }

    public static void RegisterIcon()
    {
        try
        {
            string RegText = "Windows Registry Editor Version 5.00" + Environment.NewLine;
            RegText += "[HKEY_CLASSES_ROOT\\.ese]" + Environment.NewLine + "[HKEY_CLASSES_ROOT\\.ese\\DefaultIcon]" + Environment.NewLine;
            RegText += $" @= \"{AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "\\\\")}ESEFileIcon.ico\" ";
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\ESEIconReg.REG", RegText);

            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\ESEIconReg.REG";
            Process regeditProcess = Process.Start("regedit.exe", "/s \"" + directory + "\"");
            regeditProcess.WaitForExit();
        } catch { }
        finally
        {
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\ESEIconReg.REG");
        }

        try
        {
            Process regeditProcess = Process.Start("ie4uinit.exe", "-ClearIconCache");
            regeditProcess.WaitForExit();
        }
        catch { }
        
        try
        {
            Process regeditProcess = Process.Start("ie4uinit.exe", "-show");
            regeditProcess.WaitForExit();
        }
        catch { }
    }

    public static void UnRegisterIcon()
    {
        try
        {
            string RegText = "Windows Registry Editor Version 5.00" + Environment.NewLine;
            RegText += "[HKEY_CLASSES_ROOT\\.ese]" + Environment.NewLine + "[HKEY_CLASSES_ROOT\\.ese\\DefaultIcon]" + Environment.NewLine;
            RegText += $" @= \"\" ";
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\ESEIconUnReg.REG", RegText);

            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\ESEIconUnReg.REG";
            Process regeditProcess = Process.Start("regedit.exe", "/s \"" + directory + "\"");
            regeditProcess.WaitForExit();
        }
        catch { }
    }


    //GetAllChildren can be used to get all child controls of a specific type
    public static IEnumerable<Control> GetAllChildren(this Control root)
    {
        var stack = new Stack<Control>();
        stack.Push(root);

        while (stack.Any())
        {
            var next = stack.Pop();
            foreach (Control child in next.Controls)
                stack.Push(child);
            yield return next;
        }
    }

}


