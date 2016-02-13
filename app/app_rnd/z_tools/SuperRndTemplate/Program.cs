using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using walle.update;
using walle.utils;

namespace SuperRndTemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //1.AUpdate
            AutoUpdateUtils.update("http://localhost:9999/updateInfo_SuperRndTemplate.xml");

            //2.MainService

        }
    }
}
