using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.less_walle2
{
    class LessServiceWalle2
    {
        #region Const

        private static string FILE_PATH_SRC_LESS_WALLE2()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/less_walle2/template.less");
            return strFilePath;
        }

        #endregion

        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============LessServiceWalle2 start====================");
            FileServiceLess._genByType(strSrcDirPath, "core", FILE_PATH_SRC_LESS_WALLE2());
            FileServiceLess._genByType(strSrcDirPath, "component", FILE_PATH_SRC_LESS_WALLE2());
            FileServiceLess._genByType(strSrcDirPath, "widget", FILE_PATH_SRC_LESS_WALLE2());
            Console.WriteLine("==============LessServiceWalle2 end====================");
        }
    }
}
