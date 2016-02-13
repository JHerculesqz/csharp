using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace walle.update
{
    public class DownloadZipService
    {
        #region download
        
        public string download(UpdateInfo oUpdateInfo)
        {
            LogUtils.debug("DownloadZipService.download", "start...");

            WebUtils.downloadFile(oUpdateInfo.UrlUpdateZip, DownloadZipServicePlugin.FILE_PATH_UPDATE_ZIP);

            LogUtils.debug("DownloadZipService.download", "end...");
            return DownloadZipServicePlugin.FILE_PATH_UPDATE_ZIP;
        }

        #endregion
    }
}
