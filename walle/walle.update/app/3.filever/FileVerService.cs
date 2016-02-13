using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace walle.update
{
    public class FileVerService
    {
        #region getVer

        public string getVer(string strFilePathProcess)
        {
            LogUtils.debug("FileVerService.getVer", "start...");

            //1.获得oFileVersion
            var oFileVersion = FileVerUtils.getVer(strFilePathProcess);

            LogUtils.debug("FileVerService.getVer", "end...");
            return oFileVersion.FileVersion;
        }

        #endregion
    }
}
