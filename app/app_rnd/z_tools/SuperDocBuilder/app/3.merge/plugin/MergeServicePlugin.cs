using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDocBuilder
{
    public class MergeServicePlugin
    {
        #region Const

        public static string FILE_PATH_walle(string strFilePathBase)
        {
            return Path.Combine(strFilePathBase, "walle.prj");
        }

        public static string DIR_PATH_module(string strDirPathBase, string strModule)
        {
            return Path.Combine(strDirPathBase, strModule);
        }

        internal static string DIR_PATH_module_image(string strDirPathBase, string strModule)
        {
            return Path.Combine(strDirPathBase, strModule, "image");
        }

        internal static string DIR_PATH_output_image(string strDirPathBase)
        {
            return Path.Combine(strDirPathBase, "output", "image");
        }

        internal static string FILE_PATH_output_md(string strDirPathBase)
        {
            return Path.Combine(strDirPathBase, "output", "Document.md");
        }

        #endregion
    }
}
