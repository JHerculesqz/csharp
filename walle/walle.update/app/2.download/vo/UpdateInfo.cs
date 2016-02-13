using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.update
{
    public class UpdateInfo
    {
        #region Fields

        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string urlUpdateZip;

        public string UrlUpdateZip
        {
            get { return urlUpdateZip; }
            set { urlUpdateZip = value; }
        }

        #endregion
    }
}
