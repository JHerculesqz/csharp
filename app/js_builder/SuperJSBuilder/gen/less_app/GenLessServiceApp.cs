using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.gen.less_app
{
    class GenLessServiceApp
    {
        public static void gen(string strSrcDirPath)
        {
            Console.WriteLine("==============GenLessServiceApp start====================");
            GenFileAdapterLess._genByType(strSrcDirPath, "", new FileAdapterLessApp());
            Console.WriteLine("==============GenLessServiceApp end====================");
        }
    }

    #region FileAdapterLessApp

    class FileAdapterLessApp : IGenFileAdapterLess
    {
        #region Const

        private static string FILE_PATH_TEMPLATE_LESS()
        {
            var strFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/less_app/template.less");
            return strFilePath;
        }

        private static string FILE_PATH_DST_LESS(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strModuleName), "less"), strModuleName + ".less");
            return strFilePath;
        }

        #endregion

        public string getPrefixName()
        {
            return "";
        }

        public string getTemplateFilePath()
        {
            return FILE_PATH_TEMPLATE_LESS();
        }

        public string getDstFilePath(string strSrcDirPath, string strSubDirPath, string strModuleName)
        {
            return FILE_PATH_DST_LESS(strSrcDirPath, strSubDirPath, strModuleName);
        }
    }

    #endregion
}
