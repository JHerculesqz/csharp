using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperYF
{
    public class Step2ServicePlugin
    {
        #region Const

        private static string RAW_DATA_TYPE_IN = "收入";
        private static string RAW_DATA_TYPE_OUT = "支出";

        #endregion

        #region _refreshFilePathRawData

        public static string _refreshFilePathRawData(
            string strCompanyName,
            string strDirPathRoot,
            string strRawDataTree,
            string strRawDataName)
        {
            return Path.Combine(Step1ServicePlugin.DIR_PATH_rawData(strCompanyName, strDirPathRoot),
                                string.Format(@"{0}\{1}_{2}.xlsx",
                                              strRawDataTree,
                                              strRawDataName,
                                              DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")));
        }

        #endregion

        #region _createFilePathRawData

        public static void _createFilePathRawData(string strFilePathRawData, string strRawDataType)
        {
            //1.createDir
            if (!Directory.Exists(new FileInfo(strFilePathRawData).DirectoryName))
            {
                Directory.CreateDirectory(new FileInfo(strFilePathRawData).DirectoryName);
            }

            //2.copyFile
            if (RAW_DATA_TYPE_IN == strRawDataType)
            {
                File.Copy(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\SuperYF\收入凭证.xlsx"),
                    strFilePathRawData,
                    true);
            }
            else if (RAW_DATA_TYPE_OUT == strRawDataType)
            {
                File.Copy(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\SuperYF\支出凭证.xlsx"),
                    strFilePathRawData,
                    true);
            }
        }

        #endregion
    }
}
