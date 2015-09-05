using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    class GenFileAdapterJS
    {
        #region Const

        private static string FILE_PATH_PRJ_IN_X(string strSrcDirPath, string strSubDirPath)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), "walle.prj");
        }

        private static string REPLACE_MODULE_NAME = "MODULENAME";

        #endregion

        public static void _genByType(string strSrcDirPath, string strSubDirPath, IGenFileAdapterJS oIFileAdapterJS)
        {
            var arrLines = File.ReadAllLines(FILE_PATH_PRJ_IN_X(strSrcDirPath, strSubDirPath));
            foreach (var strModuleName in arrLines)
            {
                //1.get params
                var strPrefix = oIFileAdapterJS.getPrefixName();
                var strTemplateFilePath = oIFileAdapterJS.getTemplateFilePath();
                var strDstFilePath = oIFileAdapterJS.getDstFilePath(strSrcDirPath, strSubDirPath, strModuleName);

                if (!File.Exists(strDstFilePath))
                {
                    //2.read template
                    var strContent = File.ReadAllText(strTemplateFilePath);

                    //3.update content
                    strContent = strContent.Replace(REPLACE_MODULE_NAME, ModuleNameAdapter.formatName(strModuleName, strPrefix));

                    //4.write content
                    File.WriteAllText(strDstFilePath, strContent);
                    Console.WriteLine("File:" + strDstFilePath);
                }
            }
        }
    }
}
