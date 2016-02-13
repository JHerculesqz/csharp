using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDocBuilder
{
    public class MainFormPlugin
    {
        #region formLoad

        public static void formLoad(MainForm oMainForm)
        {
            //1.m_oConfService.load
            MainService.getInstance().m_oConfService.load();

            //2.update view
            oMainForm.m_textBoxBrowser.Text = MainService.getInstance().m_oConfService.Confs[ConfServicePlugin.PROP_dirPathBase];
        }

        #endregion
    }
}
