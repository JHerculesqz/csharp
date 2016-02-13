using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbuild
{
    public class CopyServicePlugin
    {
        #region Const

        public static string DIR_PATH_NBUILD_DATA(string strDirPathSolution, string strNBuildDirName)
        {
            return Path.Combine(strDirPathSolution, @"tools\nbuild.data", strNBuildDirName);
        }

        public static string DIR_PATH_DST_PRJ_DATA(FileInfo oFileInfoNBuildXML, string strNBuildDirName)
        {
            return Path.Combine(oFileInfoNBuildXML.DirectoryName, @"data", strNBuildDirName);
        }

        #endregion
    }
}
