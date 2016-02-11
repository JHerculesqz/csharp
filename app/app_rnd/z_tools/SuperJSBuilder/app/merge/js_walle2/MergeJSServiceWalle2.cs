using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class MergeJSServiceWalle2
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeJSServiceWalle2 start=========================");
            var strContent = MergeJSAdapter.merge(strSrcDirPath, "core", new MergeJSAdaterWallE());
            strContent += MergeJSAdapter.merge(strSrcDirPath, "component", new MergeJSAdaterWallE());
            strContent += MergeJSAdapter.merge(strSrcDirPath, "widget", new MergeJSAdaterWallE());
            MergeJSAdapter.minify(strSrcDirPath, strContent, new MergeJSAdaterWallE());
            Console.WriteLine("========================MergeJSServiceWalle2 end=========================");
        }
    }

    class MergeJSAdaterWallE : IMergeJSAdapter
    {
        public string getSrcDirPathJS(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\test\\";
        }

        public string getDstFilePathJS(string strSrcDirPath)
        {
            return Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2/js/walle2.web.js");
        }

        public string getDstFilePathMinJS(string strSrcDirPath)
        {
            return Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2/js/walle2.web.min.js");
        }
    }
}
