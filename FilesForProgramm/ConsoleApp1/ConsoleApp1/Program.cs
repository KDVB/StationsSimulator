using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new System.Uri(args[0]);
            string converted = uri.AbsoluteUri;


            string browserPath = GetPathToDefaultBrowser();
            Process.Start(browserPath, converted);
        }

        private static string GetPathToDefaultBrowser()
        {
            const string currentUserSubKey =
            @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(currentUserSubKey, false))
            {
                string progId = (userChoiceKey.GetValue("ProgId").ToString());
                using (RegistryKey kp =
                       Registry.ClassesRoot.OpenSubKey(progId + @"\shell\open\command", false))
                {
                    // Get default value and convert to EXE path.
                    // It's stored as:
                    //    "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" -- "%1"
                    // So we want the first quoted string only
                    string rawValue = (string)kp.GetValue("");
                    Regex reg = new Regex("(?<=\").*?(?=\")");
                    Match m = reg.Match(rawValue);
                    return m.Success ? m.Value : "";
                }
            }
        }
    }
}
