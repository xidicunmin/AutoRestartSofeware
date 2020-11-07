using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace AutoRestartSofeware
{
    public class CheckRun
    {
        public static bool CheckAndOpenExe(string exeName,string exePath)
        {
            Process[] processes = Process.GetProcessesByName(exeName);
            if (processes.Length > 0)
            {
                return true;
            }
            else
            {
                return OpenExe(exePath);
            }
        }



        public static bool OpenExe(string exePath)
        {
            Process pr = new Process();
            try
            {
                pr.StartInfo.FileName = exePath;
                pr.Start();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (pr != null)
                {
                    pr.Close();
                }

            }
        }



        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }//获取当前代码运行的目录

    }
}
