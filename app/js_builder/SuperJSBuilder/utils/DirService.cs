using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    class DirService
    {
        #region Const

        private static string FILE_PATH_PRJ_IN_X(string strSrcDirPath, string strType)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strType), "walle.prj");
        }

        private static string DIR_PATH_DST_IN_X(string strSrcDirPath, string strDstDirName, string strType)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strType), strDstDirName);
        }

        private static string DIR_PATH_IMAGE_IN_X(string strSrcDirPath, string strDstDirName, string strType)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strType), "image");
        }

        private static string DIR_PATH_JS_IN_X(string strSrcDirPath, string strDstDirName, string strType)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strType), "js");
        }

        private static string DIR_PATH_LESS_IN_X(string strSrcDirPath, string strDstDirName, string strType)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strType), "less");
        }
        
        #endregion

        public static void _genByType(string strSrcDirPath, string strType)
        {
            var arrLines = File.ReadAllLines(FILE_PATH_PRJ_IN_X(strSrcDirPath, strType));
            foreach (var strLine in arrLines)
            {
                if (!Directory.Exists(DIR_PATH_DST_IN_X(strSrcDirPath, strLine, strType)))
                {
                    var strDirPath = DIR_PATH_DST_IN_X(strSrcDirPath, strLine, strType);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_IMAGE_IN_X(strSrcDirPath, strLine, strType)))
                {
                    var strDirPath = DIR_PATH_IMAGE_IN_X(strSrcDirPath, strLine, strType);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_JS_IN_X(strSrcDirPath, strLine, strType)))
                {
                    var strDirPath = DIR_PATH_JS_IN_X(strSrcDirPath, strLine, strType);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_LESS_IN_X(strSrcDirPath, strLine, strType)))
                {
                    var strDirPath = DIR_PATH_LESS_IN_X(strSrcDirPath, strLine, strType);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
            }
        }
    }
}
