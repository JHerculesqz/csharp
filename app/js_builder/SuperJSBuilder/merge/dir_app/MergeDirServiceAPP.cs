using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.merge.dir_app
{
    class MergeDirServiceAPP
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeDirServiceAPP start=======================");
            MergeDirAdapter.mergeByType(strSrcDirPath, new MergeDirAdapterWallE());
            Console.WriteLine("========================MergeDirServiceAPP end=======================");
        }
    }

    class MergeDirAdapterWallE : IMergeDirAdapter
    {
        public string getDstDirPath(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin");
        }
    }
}
