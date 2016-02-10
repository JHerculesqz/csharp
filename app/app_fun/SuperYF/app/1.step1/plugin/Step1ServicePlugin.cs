using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperYF
{
    public class Step1ServicePlugin
    {
        #region Const

        public static string DIR_PATH_rawData(string strCompanyName, string strDirPathRoot)
        {
            return Path.Combine(strDirPathRoot, string.Format(@"{0}\1.凭证流水", strCompanyName));
        }

        public static string DIR_PATH_classData(string strCompanyName, string strDirPathRoot)
        {
            return Path.Combine(strDirPathRoot, string.Format(@"{0}\2.财务科目", strCompanyName));
        }

        public static string DIR_PATH_reportData(string strCompanyName, string strDirPathRoot)
        {
            return Path.Combine(strDirPathRoot, string.Format(@"{0}\3.财务报表", strCompanyName));
        }

        #endregion

        #region _createDirPath

        public static void _createDirPath(string strCompanyName, string strDirPathRoot)
        {
            //1.DIR_PATH_rawData
            if (!Directory.Exists(DIR_PATH_rawData(strCompanyName, strDirPathRoot)))
            {
                Directory.CreateDirectory(DIR_PATH_rawData(strCompanyName, strDirPathRoot));   
            }

            //2.DIR_PATH_classData
            if (!Directory.Exists(DIR_PATH_classData(strCompanyName, strDirPathRoot)))
            {
                Directory.CreateDirectory(DIR_PATH_classData(strCompanyName, strDirPathRoot));
            }

            //3.DIR_PATH_reportData
            if (!Directory.Exists(DIR_PATH_reportData(strCompanyName, strDirPathRoot)))
            {
                Directory.CreateDirectory(DIR_PATH_reportData(strCompanyName, strDirPathRoot));
            }
        }

        #endregion
    }
}
