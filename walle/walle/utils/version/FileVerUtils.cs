using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    /// <summary>
    /// 参考：
    /// http://stackoverflow.com/questions/11350008/how-to-get-exe-file-version-number-from-file-path
    /// </summary>
    public class FileVerUtils
    {
        #region getVer

        public static FileVersionInfo getVer(string strFilePathExe)
        {
            return FileVersionInfo.GetVersionInfo(strFilePathExe);
        }

        #endregion
    }
}
