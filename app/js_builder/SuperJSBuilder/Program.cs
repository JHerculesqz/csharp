using SuperJSBuilder.gen.dir_app;
using SuperJSBuilder.gen.dir_walle2;
using SuperJSBuilder.merge.walle2;
using SuperJSBuilder.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJSBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.config init
            ConfigService.init();

            //2.if wall2
            if (ConfigService.getValue(ConfigService.KEY_TYPE).Equals(ConfigService.TYPE_WALLE2))
            {
                //2.1.gen
                DirServiceWalle2.gen(ConfigService.getValue(ConfigService.KEY_SRC_DIR_PATH));

                //2.2.merge
                MergeServiceWalle2.merge();
            }
            //3.if app
            else if (ConfigService.getValue(ConfigService.KEY_TYPE).Equals(ConfigService.TYPE_APP))
            {
                //3.1.gen
                DirServiceApp.gen(ConfigService.getValue(ConfigService.KEY_SRC_DIR_PATH));
            }

            Console.ReadLine();
        }
    }
}
