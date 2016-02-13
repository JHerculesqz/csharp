using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDocBuilder
{
    public class BuildServicePlugin
    {
        #region Const

        internal static string FILE_PATH_build_bat(string strDirPathBase)
        {
            return Path.Combine(strDirPathBase, "output", "build_html.bat");
        }

        #endregion
    }
}
