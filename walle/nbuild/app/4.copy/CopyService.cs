using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace nbuild
{
    public class CopyService
    {
        #region copy

        public void copy(string strDirPathSolution, List<string> lstNBuildDirName, FileInfo oFileInfoNBuildXML)
        {
            LogUtils.debug("CopyService.copy", "start...");

            foreach (var strNBuildDirName in lstNBuildDirName)
            {
                var strDirPathSrc = CopyServicePlugin.DIR_PATH_NBUILD_DATA(strDirPathSolution, strNBuildDirName);
                var strDirPathDst = CopyServicePlugin.DIR_PATH_DST_PRJ_DATA(oFileInfoNBuildXML, strNBuildDirName);

                DirUtils.del(strDirPathDst);
                FileUtils.xcopy(strDirPathSrc, strDirPathDst);
            }

            LogUtils.debug("CopyService.copy", "end...");
        }

        #endregion
    }
}
