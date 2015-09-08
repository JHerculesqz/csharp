using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.utils
{
    class MergeLessAdapter
    {
        #region Const

        private static string IMG_TYPE_LESS = ".less";

        #endregion

        public static string merge(string strSrcDirPath, string strSubDirName, IMergeLessAdapter oIMergeLessAdapter)
        {
            //0.get srcDirPath
            var strSrcDirPathLess = oIMergeLessAdapter.getSrcDirPathLess(strSrcDirPath, strSubDirName);

            //1.get all js files
            var lstLessInDir = new List<FileInfo>();
            FileUtils.getFilesInDir(strSrcDirPathLess, IMG_TYPE_LESS, ref lstLessInDir);

            var strContent = "";
            foreach (var oFileLess in lstLessInDir)
            {
                if (!string.IsNullOrEmpty(oIMergeLessAdapter.getIgnoreName()))
                {
                    if (oFileLess.FullName.Contains(oIMergeLessAdapter.getIgnoreName()))
                    {
                        continue;
                    }
                }

                //2.merge all js files
                strContent += File.ReadAllText(oFileLess.FullName) + Environment.NewLine;
            }

            return strContent;
        }

        public static void minify(string strSrcDirPath, string strContent, IMergeLessAdapter oIMergeLessAdapter)
        {
            //3.write file
            var strDstFilePathLess = oIMergeLessAdapter.getDstFilePathLess(strSrcDirPath);
            File.WriteAllText(strDstFilePathLess, strContent);
            Console.WriteLine(new FileInfo(strDstFilePathLess).Name);

            //4.minify js
            var strYUIPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/node_modules/.bin/lessc.cmd");
            var strDstFilePathMinLess = oIMergeLessAdapter.getDstFilePathMinLess(strSrcDirPath);
            LessMinifyUtils.minifyLess(strYUIPath, strDstFilePathLess, strDstFilePathMinLess);
            Console.WriteLine(new FileInfo(strDstFilePathMinLess).Name);
        }
    }
}
