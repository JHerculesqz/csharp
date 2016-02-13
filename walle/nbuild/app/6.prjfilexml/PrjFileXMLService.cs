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
    public class PrjFileXMLService
    {
        #region updatePrjFileXML

        public void updatePrjFileXML(List<FileInfo> lstFileInfoFileInData, FileInfo oFileInfoNBuildXML, FileInfo oFileInfoPrjFile)
        {
            LogUtils.debug("PrjFileXMLService.updatePrjFileXML", "start...");

            foreach (var oFileInfoFileInData in lstFileInfoFileInData)
            {
                //1.根据oFileInfoFileInData/oFileInfoNBuildXML，获得strRelativePathFileInData
                var strRelativePathFileInData = oFileInfoFileInData.FullName.Replace(oFileInfoNBuildXML.DirectoryName + @"\", "");

                //2.在oFileInfoPrjFile中查找lstEleFileInData
                //2.1.get oDoc
                XNamespace oXNamespace = @"http://schemas.microsoft.com/developer/msbuild/2003";
                var oDoc = XElement.Load(oFileInfoPrjFile.FullName);
                //2.2.get lstEleFileInData
                var lstEleFileInData = new List<XElement>();
                foreach (var oEleItemGroup in oDoc.Elements(oXNamespace + "ItemGroup"))
                {
                    foreach (var oEleContent in oEleItemGroup.Elements())
                    {
                        if (oEleContent.Attribute("Include").Value == strRelativePathFileInData)
                        {
                            lstEleFileInData.Add(oEleContent);
                        }
                    }
                }
                //2.4.遍历lstEleFileInData，删除
                foreach (var oEleFileInData in lstEleFileInData)
                {
                    oEleFileInData.Remove();
                }
                //2.5.add<Content>标签
                var oEleItemGroupLast = oDoc.Elements(oXNamespace + "ItemGroup").Last();
                if (null == oEleItemGroupLast)
                {
                    oEleItemGroupLast = new XElement(oXNamespace + "ItemGroup");
                    oDoc.Add(oEleItemGroupLast);
                }
                var oEleContentNew = new XElement(oXNamespace + "Content",
                    new XAttribute("Include", strRelativePathFileInData),
                    new XElement(oXNamespace + "CopyToOutputDirectory", "Always"));
                oEleItemGroupLast.Add(oEleContentNew);
                //2.6.save
                oDoc.Save(oFileInfoPrjFile.FullName);
            }

            LogUtils.debug("PrjFileXMLService.updatePrjFileXML", "end...");
        }

        #endregion
    }
}
