using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using walle.utils;

namespace walle.update
{
    public class MainService
    {
        #region Fields

        private ClearService m_oClearService = new ClearService();
        private DownloadService m_oDownloadService = new DownloadService();
        private FileVerService m_oFileVerService = new FileVerService();
        private ProcessService m_oProcessService = new ProcessService();
        private DownloadZipService m_oDownloadZipService = new DownloadZipService();
        private UnzipService m_oUnzipService = new UnzipService();

        #endregion

        #region Constrcution

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

        #region update

        public void update(string[] args)
        {
            //0.get params
            if (args.Length != MainServicePlugin.COUNT_ARGS)
            {
                LogUtils.error("walle.udate.Program", "args error...");
                return;
            }
            var oDownloadVo = new DownloadVo();
            oDownloadVo.FilePathProcess = args[0];
            oDownloadVo.Url = args[1];

            //1.clear
            this.m_oClearService.clear();

            //2.读取strUrlUpdateXML
            UpdateInfo oUpdateInfo;
            try
            {
                oUpdateInfo = this.m_oDownloadService.download(oDownloadVo);
            }
            catch (Exception)
            {
                LogUtils.error("walle.udate.Program", "DownloadService error...");
                return;
            }

            //3.读取strProcessName的strVersion
            var strVersion = "";
            try
            {
                strVersion = this.m_oFileVerService.getVer(oDownloadVo.FilePathProcess);
            }
            catch (Exception)
            {
                LogUtils.error("walle.udate.Program", "FileVerService error...");
                //return;
            }

            //4.如果oUpdateInfo.version == strVersion
            if (oUpdateInfo.Version != strVersion)
            {
                //4.0.确认是否更新
                var oDialogResult = new ConfirmForm().ShowDialog();
                if (oDialogResult == DialogResult.OK)
                {
                    //4.1.Kill strProcessName
                    this.m_oProcessService.kill(oDownloadVo.FilePathProcess);

                    //4.2.根据oUpdateInfo，下载zip到strFilePathZip
                    var strFilePathZip = this.m_oDownloadZipService.download(oUpdateInfo);

                    //4.3.根据strFilePathZip,解压到strDirPathZip
                    this.m_oUnzipService.unzip(strFilePathZip, oDownloadVo.FilePathProcess);

                    //4.4.start strProcessName
                    this.m_oProcessService.start(oDownloadVo.FilePathProcess);    
                }
            }
        }

        #endregion
    }
}
