using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperJSBuilder.utils
{
    interface IMergeLessAdapter
    {
        string getSrcDirPathLess(string strSrcDirPath, string strSubDirName);

        string getIgnoreName();

        string getDstFilePathLess(string strSrcDirPath);

        string getDstFilePathMinLess(string strSrcDirPath);
    }
}
