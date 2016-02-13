using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace nbuild
{
    public class PrjFileService
    {
        #region getPrjFiles

        public List<FileInfo> getPrjFiles(string strDirPathSolution)
        {
            LogUtils.debug("PrjFileService.getPrjFiles", "start...");

            List<FileInfo> lstFileInfoPrjFile = new List<FileInfo>();
            FileUtils.getFilesInDir(strDirPathSolution, ".csproj", ref lstFileInfoPrjFile);

            LogUtils.debug("PrjFileService.getPrjFiles", "end...");
            return lstFileInfoPrjFile;
        }

        #endregion
    }
}
