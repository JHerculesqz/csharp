﻿using System;
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

        public static void openAppByBlock(string strCmd, string strArgs)
        {
            var oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.FileName = strCmd;
            oProcessStartInfo.Arguments = strArgs;

            var oProcess = Process.Start(oProcessStartInfo);
            oProcess.WaitForExit();
        }

        #endregion
    }
}
