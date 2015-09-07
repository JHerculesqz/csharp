using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.merge.less_walle2
{
    class MergeLessServiceWalle
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeJSServiceWalle2 start=========================");
            //var strContent = MergeLessAdapter.merge(strSrcDirPath, "core", new MergeLessAdaterWallE());
            //strContent += MergeLessAdapter.merge(strSrcDirPath, "component", new MergeLessAdaterWallE());
            //strContent += MergeLessAdapter.merge(strSrcDirPath, "widget", new MergeLessAdaterWallE());
            //MergeJSAdapter.minify(strSrcDirPath, strContent, new MergeLessAdaterWallE());
            Console.WriteLine("========================MergeJSServiceWalle2 end=========================");
        }
    }

    class MergeLessAdaterWallE// : IMergeLessAdapter
    {
        public string getSrcDirPathCss(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\test\\";
        }

        public string getDstFilePathCss(string strSrcDirPath)
        {
            return Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2/less/walle2.web.less");
        }

        public string getDstFilePathMinCss(string strSrcDirPath)
        {
            return Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2/less/walle2.web.min.css");
        }
    }
}
