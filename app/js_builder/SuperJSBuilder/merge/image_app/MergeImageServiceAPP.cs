using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walle.utils;

namespace SuperJSBuilder.merge.image_app
{
    class MergeImageServiceAPP
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeImageServiceAPP start=========================");
            MergeImgAdapter.merge(strSrcDirPath, "", new MergeImageAdaterAPP());
            Console.WriteLine("========================MergeImageServiceAPP end=========================");
        }
    }

    class MergeImageAdaterAPP : IMergeImageAdapter
    {
        public string getSrcDirPathImg(string strSrcDirPath, string strSubDirName)
        {
            return Path.Combine(strSrcDirPath, strSubDirName);
        }

        public string getIgnoreName()
        {
            return "\\bin\\";
        }

        public string getDstFilePathImg(string strSrcDirPath, string strImgFileName)
        {
            return Path.Combine(Path.Combine(strSrcDirPath, "bin/image"), strImgFileName);
        }
    }
}
