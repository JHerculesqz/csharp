using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walle.utils
{
    public class TreeViewUtils
    {
        #region expandAll

        public static void expandAll(TreeView oTreeView)
        {
            oTreeView.ExpandAll();
        }

        public static void collapseAll(TreeView oTreeView)
        {
            oTreeView.CollapseAll();
        }

        #endregion
    }
}
