using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class FileUtils
    {
        public static void getFilesInDir(string strDirPath, string strPrefix, ref List<FileInfo> lstFileInDirecotry)
        {
            DirectoryInfo oSrcDir = new DirectoryInfo(strDirPath);
            if (oSrcDir.Exists)
            {
                var lstSubDirectories = oSrcDir.GetDirectories();
                foreach (var oSubDirectory in lstSubDirectories)
                {
                    getFilesInDir(oSubDirectory.FullName, strPrefix, ref lstFileInDirecotry);
                }

                foreach (var oFile in oSrcDir.GetFiles())
                {
                    if (string.IsNullOrEmpty(strPrefix))
                    {
                        lstFileInDirecotry.Add(oFile);
                    }
                    else
                    {
                        if (oFile.FullName.EndsWith(strPrefix))
                        {
                            lstFileInDirecotry.Add(oFile);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Dir not exists:" + strDirPath);
            }
        }
    }
}
