using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder.utils
{
    interface IMergeImageAdapter
    {
        string getSrcDirPathImg(string strSrcDirPath, string strSubDirName);

        string getIgnoreName();

        string getDstFilePathImg(string strSrcDirPath, string strImgFileName);
    }
}
