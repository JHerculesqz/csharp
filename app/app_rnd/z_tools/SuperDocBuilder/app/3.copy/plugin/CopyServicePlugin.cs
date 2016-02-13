using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDocBuilder
{
    public class CopyServicePlugin
    {
        #region Const

        public static string DIR_PATH_SRC = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\SuperDocBuilder\Sample2");

        public static string DIR_PATH_DST(string strDirPathBase)
        {
            return Path.Combine(strDirPathBase, @"output");
        }

        #endregion
    }
}
