using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.update
{
    public class DownloadVo
    {
        #region Fields

        private string filePathProcess;

        public string FilePathProcess
        {
            get { return filePathProcess; }
            set { filePathProcess = value; }
        }


        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        #endregion
    }
}
