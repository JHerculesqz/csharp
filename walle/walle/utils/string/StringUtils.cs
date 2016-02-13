using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class StringUtils
    {
        public static string toTitleCase(string strName)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(strName);
        }
    }
}
