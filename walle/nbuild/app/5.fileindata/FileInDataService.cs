using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace nbuild
{
    public class FileInDataService
    {
        #region getLstFileInfoFileInData

        public List<FileInfo> getLstFileInfoFileInData(FileInfo oFileInfoNBuildXML)
        {
            LogUtils.debug("FileInDataService.getLstFileInfoFileInData", "start...");

            List<FileInfo> lstFileInfoFileInData = new List<FileInfo>();

            var strDirPathData = Path.Combine(oFileInfoNBuildXML.DirectoryName, @"data");
            FileUtils.getFilesInDir(strDirPathData, "", ref lstFileInfoFileInData);

            LogUtils.debug("FileInDataService.getLstFileInfoFileInData", "end...");
            return lstFileInfoFileInData;
        }

        #endregion
    }
}
