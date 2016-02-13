using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbuild
{
    public class MainService
    {
        #region Fields

        private SolutionService m_oSolutionService = new SolutionService();
        private PrjFileService m_oPrjFileService = new PrjFileService();
        private NBuildXMLService m_oNBuildXMLService = new NBuildXMLService();
        private CopyService m_oCopyService = new CopyService();
        private FileInDataService m_oFileInDataService = new FileInDataService();
        private PrjFileXMLService m_oPrjFileXMLService = new PrjFileXMLService();

        #endregion

        #region Construction

        private static MainService m_oInstance;

        private MainService() { }

        public static MainService getInstance()
        {
            if (m_oInstance == null)
            {
                m_oInstance = new MainService();
            }

            return m_oInstance;
        }

        #endregion

        #region run

        public void run()
        {
            //1.获得strDirPathSolution
            var strDirPathSolution = this.m_oSolutionService.getDirPathSolution();

            //2.根据strDirPathSolution，获得lstFileInfoPrjFile
            var lstFileInfoPrjFile = this.m_oPrjFileService.getPrjFiles(strDirPathSolution);

            //3.遍历lstFileInfoPrjFile
            foreach (var oFileInfoPrjFile in lstFileInfoPrjFile)
            {
                //3.1.根据oFileInfoPrjFile,获得同级目录的oFileInfoNBuildXML
                var oFileInfoNBuildXML = this.m_oNBuildXMLService.getFileInfoNBuildXML(oFileInfoPrjFile);

                //3.2.如果oFileInfoNBuildXML==null,则continue
                if (null == oFileInfoNBuildXML)
                {
                    continue;
                }
                //3.3.如果oFileInfoNBuildXML!=null,则
                else
                {
                    //3.3.1.解析oFileInfoNBuildXML，获得lstNBuildDirName
                    var lstNBuildDirName = this.m_oNBuildXMLService.parseNBuildDirNameLst(oFileInfoNBuildXML);

                    //3.3.2.根据strDirPathSolution/lstNBuildDirName/oFileInfoNBuildXML，xcopy到oFileInfoNBuildXML所在的data目录
                    this.m_oCopyService.copy(strDirPathSolution, lstNBuildDirName, oFileInfoNBuildXML);

                    //3.3.2.根据oFileInfoNBuildXML，获得lstFileInfoFileInData
                    List<FileInfo> lstFileInfoFileInData = this.m_oFileInDataService.getLstFileInfoFileInData(oFileInfoNBuildXML);

                    //3.3.3.根据oFileInfoFileInData/oFileInfoNBuildXML，在oFileInfoPrjFile中添加oFileInfoFileInData标签
                    this.m_oPrjFileXMLService.updatePrjFileXML(lstFileInfoFileInData, oFileInfoNBuildXML, oFileInfoPrjFile);
                }
            }
        }

        #endregion
    }
}
