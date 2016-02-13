using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using walle.utils;

namespace walle.update
{
    public class DownloadService
    {
        #region download

        public UpdateInfo download(DownloadVo oDownloadVo)
        {
            LogUtils.debug("DownloadService.download", "start...");

            //1.创建文件夹
            var oDirInfo = new FileInfo(DownloadServicePlugin.FILE_PATH_TMP_XML).Directory;
            if (!oDirInfo.Exists)
            {
                oDirInfo.Create();
            }

            //2.download
            WebUtils.downloadFile(oDownloadVo.Url, DownloadServicePlugin.FILE_PATH_TMP_XML);

            //3.parse
            var oUpdateInfo = DownloadServicePlugin.parse();

            LogUtils.debug("DownloadService.download", "end...");

            return oUpdateInfo;
        }

        #endregion
    }
}
