using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.utils
{
    class MergeJSAdapter
    {
        #region Const

        private static string IMG_TYPE_JS = ".js";

        #endregion

        public static string merge(string strSrcDirPath, string strSubDirName, IMergeJSAdapter oIMergeJSAdapter)
        {
            //0.get srcDirPath
            var strSrcDirPathJS = oIMergeJSAdapter.getSrcDirPathJS(strSrcDirPath, strSubDirName);

            //1.get all js files
            var lstJSInDir = new List<FileInfo>();
            FileUtils.getFilesInDir(strSrcDirPathJS, IMG_TYPE_JS, ref lstJSInDir);

            var strContent = "";
            foreach (var oFileJS in lstJSInDir)
            {
                if (!string.IsNullOrEmpty(oIMergeJSAdapter.getIgnoreName()))
                {
                    if (oFileJS.FullName.Contains(oIMergeJSAdapter.getIgnoreName()))
                    {
                        continue;
                    }
                }

                //2.merge all js files
                strContent += File.ReadAllText(oFileJS.FullName) + Environment.NewLine;
            }

            return strContent;
        }

        public static void minify(string strSrcDirPath, string strContent, IMergeJSAdapter oIMergeJSAdapter)
        {
            //3.write file
            var strDstFilePathJS = oIMergeJSAdapter.getDstFilePathJS(strSrcDirPath);
            File.WriteAllText(strDstFilePathJS, strContent);
            Console.WriteLine(new FileInfo(strDstFilePathJS).Name);

            //4.minify js
            var strYUIPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSBuilder/yuicompressor-2.4.8.jar");
            var strDstFilePathMinJS = oIMergeJSAdapter.getDstFilePathMinJS(strSrcDirPath);
            JSMinifyUtils.minifyJS(strYUIPath, strDstFilePathJS, strDstFilePathMinJS);
            Console.WriteLine(new FileInfo(strDstFilePathMinJS).Name);
        }
    }
}
