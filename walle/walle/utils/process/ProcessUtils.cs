using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    /// <summary>
    /// 参考:
    /// http://www.cnblogs.com/eaglet/archive/2008/03/31/1131703.html
    /// http://it.zhaozhao.info/archives/28288
    /// 
    /// </summary>
    public class ProcessUtils
    {
        #region openApp

        public static void openApp(string strFilePath)
        {
            Process.Start(strFilePath);
        }

        public static void openApp(string strCmd, string strArgs)
        {
            var oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.FileName = strCmd;
            oProcessStartInfo.Arguments = strArgs;

            Process.Start(oProcessStartInfo);
        }

        public static void openAppByBlock(string strCmd, string strArgs)
        {
            var oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.FileName = strCmd;
            oProcessStartInfo.Arguments = strArgs;

            var oProcess = Process.Start(oProcessStartInfo);
            oProcess.WaitForExit();
        }

        public static void openAppByBlockAndEnv(string strCmd, string strArgs)
        {
            var oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.FileName = strCmd;
            oProcessStartInfo.Arguments = strArgs;
            foreach (DictionaryEntry oEnvVar in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User))
	        {
                if (!oProcessStartInfo.EnvironmentVariables.ContainsKey(oEnvVar.Key.ToString()))
	            {
                    oProcessStartInfo.EnvironmentVariables.Add(oEnvVar.Key.ToString(), oEnvVar.Value.ToString());
	            }
                
	        }
            oProcessStartInfo.UseShellExecute = false;
            var oProcess = Process.Start(oProcessStartInfo);
            oProcess.WaitForExit();
        }

        #endregion

        #region kill

        public static void kill(string strProcessName)
        {
            var lstProcess = Process.GetProcesses().ToList();
            foreach (var oProcess in lstProcess)
            {
                if (strProcessName.Contains(oProcess.ProcessName))
                {
                    oProcess.Kill();   
                }
            }
        }

        #endregion
    }
}
