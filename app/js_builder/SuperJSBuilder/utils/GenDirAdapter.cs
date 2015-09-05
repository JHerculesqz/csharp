using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    class GenDirAdapter
    {
        #region Const

        private static string FILE_PATH_PRJ_IN_X(string strSrcDirPath, string strSubDirPath)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), "walle.prj");
        }

        private static string DIR_PATH_DST_IN_X(string strSrcDirPath, string strDstDirName, string strSubDirPath)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, strSubDirPath), strDstDirName);
        }

        private static string DIR_PATH_IMAGE_IN_X(string strSrcDirPath, string strDstDirName, string strSubDirPath)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strSubDirPath), "image");
        }

        private static string DIR_PATH_JS_IN_X(string strSrcDirPath, string strDstDirName, string strSubDirPath)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strSubDirPath), "js");
        }

        private static string DIR_PATH_LESS_IN_X(string strSrcDirPath, string strDstDirName, string strSubDirPath)
        {
            return Path.Combine(DIR_PATH_DST_IN_X(strSrcDirPath, strDstDirName, strSubDirPath), "less");
        }
        
        #endregion

        public static void _genByType(string strSrcDirPath, string strSubDirPath)
        {
            var arrLines = File.ReadAllLines(FILE_PATH_PRJ_IN_X(strSrcDirPath, strSubDirPath));
            foreach (var strLine in arrLines)
            {
                if (!Directory.Exists(DIR_PATH_DST_IN_X(strSrcDirPath, strLine, strSubDirPath)))
                {
                    var strDirPath = DIR_PATH_DST_IN_X(strSrcDirPath, strLine, strSubDirPath);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_IMAGE_IN_X(strSrcDirPath, strLine, strSubDirPath)))
                {
                    var strDirPath = DIR_PATH_IMAGE_IN_X(strSrcDirPath, strLine, strSubDirPath);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_JS_IN_X(strSrcDirPath, strLine, strSubDirPath)))
                {
                    var strDirPath = DIR_PATH_JS_IN_X(strSrcDirPath, strLine, strSubDirPath);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
                if (!Directory.Exists(DIR_PATH_LESS_IN_X(strSrcDirPath, strLine, strSubDirPath)))
                {
                    var strDirPath = DIR_PATH_LESS_IN_X(strSrcDirPath, strLine, strSubDirPath);
                    Directory.CreateDirectory(strDirPath);
                    Console.WriteLine("Dir:" + strDirPath);
                }
            }
        }
    }
}
