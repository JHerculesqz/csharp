using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    class MergeDirAdapter
    {
        public static void mergeByType(string strSrcDirPath, IMergeDirAdapter oIMergeDirAdapter)
        {
            //1.获得strDstDirPath
            var strDstDirPath = oIMergeDirAdapter.getDstDirPath(strSrcDirPath);
            var strDstDirPathImage = Path.Combine(strDstDirPath, "image");
            var strDstDirPathLess = Path.Combine(strDstDirPath, "less");
            var strDstDirPathJs = Path.Combine(strDstDirPath, "js");

            //2.如果strDstDirPath不存在，则创建
            if (!Directory.Exists(strDstDirPath))
            {
                Directory.CreateDirectory(strDstDirPath);
                Console.WriteLine(new DirectoryInfo(strDstDirPath).Name);
            }
            if (!Directory.Exists(strDstDirPathImage))
            {
                Directory.CreateDirectory(strDstDirPathImage);
                Console.WriteLine(new DirectoryInfo(strDstDirPathImage).Name);
            }
            if (!Directory.Exists(strDstDirPathLess))
            {
                Directory.CreateDirectory(strDstDirPathLess);
                Console.WriteLine(new DirectoryInfo(strDstDirPathLess).Name);
            }
            if (!Directory.Exists(strDstDirPathJs))
            {
                Directory.CreateDirectory(strDstDirPathJs);
                Console.WriteLine(new DirectoryInfo(strDstDirPathJs).Name);
            }
        }
    }
}
