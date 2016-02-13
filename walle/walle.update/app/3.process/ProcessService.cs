using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace walle.update
{
    public class ProcessService
    {
        #region kill

        public void kill(string strFilePathProcess)
        {
            LogUtils.debug("ProcessService.kill", "start...");

            var strProcessName = new FileInfo(strFilePathProcess).Name;
            ProcessUtils.kill(strProcessName);

            LogUtils.debug("ProcessService.kill", "end...");
        }

        #endregion

        #region start

        public void start(string strFilePathProcess)
        {
            LogUtils.debug("ProcessService.start", "start...");

            //1.open strFilePathProcess
            ProcessUtils.openApp(strFilePathProcess);

            LogUtils.debug("ProcessService.start", "end...");
        }

        #endregion
    }
}
