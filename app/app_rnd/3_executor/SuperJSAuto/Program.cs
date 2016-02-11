using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSAuto
{
    class Program
    {
        #region Const

        private static string PATH_CHROME_DRIVER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/SuperJSAuto");

        #endregion

        static void Main(string[] args)
        {
            IWebDriver oIWebDriver = new ChromeDriver(PATH_CHROME_DRIVER);
            oIWebDriver.Navigate().GoToUrl("http://www.baidu.com");
            ((IJavaScriptExecutor)oIWebDriver).ExecuteScript("alert(1);");
        }
    }
}
