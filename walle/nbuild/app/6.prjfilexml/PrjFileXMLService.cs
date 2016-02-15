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

            //1.get oDocPrjFile
            XNamespace oXNamespace = @"http://schemas.microsoft.com/developer/msbuild/2003";
            var oDocPrjFile = XElement.Load(oFileInfoPrjFile.FullName);
            //2.get lstEleNoneOrContent
            var lstEleNoneOrContent = new List<XElement>();
            foreach (var oEleItemGroup in oDocPrjFile.Elements(oXNamespace + "ItemGroup"))
            {
                foreach (var oEleContent in oEleItemGroup.Elements())
                {
                    if (oEleContent.Name.LocalName == "None" ||
                        oEleContent.Name.LocalName == "Content")
                    {
                        lstEleNoneOrContent.Add(oEleContent);
                    }
                }
            }
            //3.遍历lstEleNoneOrContent，删除
            foreach (var oEleNoneOrContent in lstEleNoneOrContent)
            {
                oEleNoneOrContent.Remove();
            }

            //4.modify oDocPrjFile for lstFileInfoFileInData
            foreach (var oFileInfoFileInData in lstFileInfoFileInData)
            {
                //4.1.根据oFileInfoFileInData/oFileInfoNBuildXML，获得strRelativePathFileInData
                var strRelativePathFileInData = oFileInfoFileInData.FullName.Replace(oFileInfoNBuildXML.DirectoryName + @"\", "");

                //4.2.add<Content>标签
                var oEleItemGroupLast = oDocPrjFile.Elements(oXNamespace + "ItemGroup").Last();
                if (null == oEleItemGroupLast)
                {
                    oEleItemGroupLast = new XElement(oXNamespace + "ItemGroup");
                    oDocPrjFile.Add(oEleItemGroupLast);
                }
                var oEleContentNew = new XElement(oXNamespace + "Content",
                    new XAttribute("Include", strRelativePathFileInData),
                    new XElement(oXNamespace + "CopyToOutputDirectory", "Always"));
                oEleItemGroupLast.Add(oEleContentNew);
            }

            //5.save
            oDocPrjFile.Save(oFileInfoPrjFile.FullName);

            LogUtils.debug("PrjFileXMLService.updatePrjFileXML", "end...");
        }

        #endregion
    }
}
