using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperJSBuilder
{
    interface IMergeLessAdapter
    {
        string getSrcDirPathLess(string strSrcDirPath, string strSubDirName);

        string getIgnoreName();

        string getImportLess();

        string getDstFilePathLess(string strSrcDirPath);

        string getDstFilePathMinLess(string strSrcDirPath);
    }
}
