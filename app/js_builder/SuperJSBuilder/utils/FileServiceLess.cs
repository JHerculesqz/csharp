using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    class FileServiceLess
    {
        #region Const

        private static string FILE_PATH_PRJ_IN_X(string strSrcDirPath, string strType)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strType), "walle.prj");
        }

        private static string FILE_PATH_DST_LESS_IN_X(string strSrcDirPath, string strModuleName, string strType)
        {
            var strFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(strSrcDirPath, strType), strModuleName), "less"), strModuleName + ".less");
            return strFilePath;
        }

        #endregion

        public static void _genByType(string strSrcDirPath, string strType, string strTemplateFilePath)
        {
            var arrLines = File.ReadAllLines(FILE_PATH_PRJ_IN_X(strSrcDirPath, strType));
            foreach (var strLine in arrLines)
            {
                if (!File.Exists(FILE_PATH_DST_LESS_IN_X(strSrcDirPath, strLine, strType)))
                {
                    var strContent = File.ReadAllText(strTemplateFilePath);
                    var strDstFilePath = FILE_PATH_DST_LESS_IN_X(strSrcDirPath, strLine, strType);
                    File.WriteAllText(strDstFilePath, strContent);
                    Console.WriteLine("File:" + strDstFilePath);
                }
            }
        }
    }
}
