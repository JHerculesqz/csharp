using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    /// <summary>
    /// 参考:
    /// http://www.cnblogs.com/top5/archive/2011/04/27/2030960.html
    /// </summary>
    public class ZipUtils
    {
        #region Const

        private static string FILE_PATH_7Z = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\walle\7z32\7z.exe");

        private static string CMD_UNZIP = "x \"{0}\" -o\"{1}\" -aoa";

        #endregion

        #region zip

        #endregion

        #region unzip

        public static void unzip(string strFilePathZip, string strDirPathDst)
        {
            ProcessUtils.openAppByBlock(FILE_PATH_7Z, string.Format(CMD_UNZIP, strFilePathZip, strDirPathDst));
        }

        #endregion
    }
}
