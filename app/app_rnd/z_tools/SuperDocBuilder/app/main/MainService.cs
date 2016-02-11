using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDocBuilder
{
    public class MainService
    {
        #region Fields

        public ConfService m_oConfService = new ConfService();
        public CopyService m_oCopyService = new CopyService();
        public MergeService m_oMergeService = new MergeService();
        public BuildService m_oBuildService = new BuildService();
        
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
            //1.m_oConfService.load
            m_oConfService.load();

            //2.m_oCopyService.copy
            m_oCopyService.copy();

            //3.m_oMergeService.merge
            m_oMergeService.merge();

            //4.m_oBuildService.build
            m_oBuildService.build();

            Console.ReadLine();
        }

        #endregion
    }
}
