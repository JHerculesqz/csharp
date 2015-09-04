using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.less_app
{
    class LessServiceApp
    {
        #region Const

        private static string FILE_PATH_SRC_LESS_APP()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/less_app/template.less");
            return strFilePath;
        }

        #endregion

        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============LessServiceWalle2 start====================");
            FileServiceLess._genByType(strSrcDirPath, "", FILE_PATH_SRC_LESS_APP());
            Console.WriteLine("==============LessServiceWalle2 end====================");
        }
    }
}
