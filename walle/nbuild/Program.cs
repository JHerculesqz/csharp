using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nbuild
{
    static class Program
    {
        static void Main()
        {
            MainService.getInstance().run();
            Console.ReadLine();
        }
    }
}
