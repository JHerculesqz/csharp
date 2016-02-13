using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperDocBuilder
{
    public class UnzipServicePlugin
    {
        #region Const

        public static string FILE_PATH_SRC_Sample2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\SuperDocBuilder\Sample2.zip");
        public static string DIR_PATH_SRC_Sample2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\SuperDocBuilder");

        #endregion

        #region unzip

        internal static void unzip()
        {
            ZipUtils.unzip(FILE_PATH_SRC_Sample2, DIR_PATH_SRC_Sample2);
        }

        #endregion
    }
}
