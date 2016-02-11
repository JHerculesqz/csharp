using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class MergeDirServiceAPP
    {
        public static void merge(string strSrcDirPath)
        {
            Console.WriteLine("========================MergeDirServiceAPP start=======================");
            MergeDirAdapter.mergeByType(strSrcDirPath, new MergeDirAdapterApp());
            Console.WriteLine("========================MergeDirServiceAPP end=======================");
        }
    }

    class MergeDirAdapterApp : IMergeDirAdapter
    {
        public string getDstDirPath(string strSrcDirPath)
        {
            return Path.Combine(strSrcDirPath, "bin");
        }
    }
}
