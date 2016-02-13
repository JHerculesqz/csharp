using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using walle.utils;

namespace nbuild
{
    public class NBuildXMLService
    {
        #region getFileInfoNBuildXML

        public FileInfo getFileInfoNBuildXML(FileInfo oFileInfoPrjFile)
        {
            FileInfo oFileInfo = null;

            var strFilePathNBuildXML = Path.Combine(oFileInfoPrjFile.DirectoryName, "nbuild.xml");
            if (File.Exists(strFilePathNBuildXML))
            {
                oFileInfo = new FileInfo(strFilePathNBuildXML);
            }

            return oFileInfo;
        }

        #endregion

        #region parseNBuildDirNameLst

        public List<string> parseNBuildDirNameLst(FileInfo oFileInfoNBuildXML)
        {
            LogUtils.debug("NBuildXMLService.parseNBuildDirNameLst", "start...");

            List<string> lstRes = new List<string>();

            var oDoc = XElement.Load(oFileInfoNBuildXML.FullName);
            foreach (var oEleItem in oDoc.Elements())
            {
                lstRes.Add(oEleItem.Value.Trim());
            }

            LogUtils.debug("NBuildXMLService.parseNBuildDirNameLst", "end...");
            return lstRes;
        }

        #endregion
    }
}
