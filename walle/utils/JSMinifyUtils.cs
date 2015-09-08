using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class JSMinifyUtils
    {
        public static void minifyJS(string strYUIPath, string strSrcFilePath, string strDstFilePath)
        {
            var strFileName = "java";
            var strArgs = "-jar " + strYUIPath + " --type js --charset utf-8 " + strSrcFilePath + " > " + strDstFilePath;
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = strFileName;
            p.Arguments = strArgs;
            p.UseShellExecute = false;
            p.RedirectStandardInput = true;
            p.RedirectStandardOutput = true;
            p.CreateNoWindow = true;
            Process oProcess = Process.Start(p);
            StreamReader reader = oProcess.StandardOutput;
            string line = reader.ReadLine();
            while(!reader.EndOfStream)
            {
                line = reader.ReadLine();
            }
            oProcess.WaitForExit();
            oProcess.Close();
            reader.Close();
        }
    }
}
