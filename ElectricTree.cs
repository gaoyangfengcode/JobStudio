using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStudio.Controls
{
    class ElectricTree : TreeView
    {
        TreeNode ProjectNode = new TreeNode();
        public ElectricTree(string projectName)
        {
            ProjectNode.Text = projectName;
        }
    }

    
}
