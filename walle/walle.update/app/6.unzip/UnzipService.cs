using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace walle.update
{
    public class UnzipService
    {
        #region unzip

        public void unzip(string strFilePathZip, string strFilePathProcess)
        {
            LogUtils.debug("UnzipService.unzip", "start...");

            var strDirPathDst = new FileInfo(strFilePathProcess).DirectoryName;
            ZipUtils.unzip(strFilePathZip, strDirPathDst);

            LogUtils.debug("UnzipService.unzip", "end...");
        }

        #endregion
    }
}
