using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperYF
{
    public class MainService
    {
        #region Fields

        public Step1Service m_oStep1Service = new Step1Service();
        public Step2Service m_oStep2Service = new Step2Service();

        #endregion

        #region Construction

        private static MainService m_oInstance;
        public static MainService getInstance()
        {
            if (m_oInstance == null)
            {
                m_oInstance = new MainService();
            }
            return m_oInstance;
        }

        #endregion
    }
}
