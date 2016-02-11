using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder
{
    class MergeImageServiceWalle2
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeImageServiceWalle2 start=========================");
            MergeImgAdapter.merge(strSrcDirPath, "core", new MergeImageAdaterWallE());
            MergeImgAdapter.merge(strSrcDirPath, "component", new MergeImageAdaterWallE());
            MergeImgAdapter.merge(strSrcDirPath, "widget", new MergeImageAdaterWallE());
            Console.WriteLine("========================MergeImageServiceWalle2 end=========================");
        }
    }

    class MergeImageAdaterWallE : IMergeImageAdapter
    {
        public string getSrcDirPathImg(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\test\\";
        }

        public string getDstFilePathImg(string strSrcDirPath, string strImgFileName)
        {
            return Path.Combine(Path.Combine(new DirectoryInfo(strSrcDirPath).Parent.FullName, "lib/walle2/image"), strImgFileName);
        }
    }
}
