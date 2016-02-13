using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walle.update
{
    static class Program
    {
        static void Main(string[] args)
        {
            MainService.getInstance().update(args);
        }
    }
}
