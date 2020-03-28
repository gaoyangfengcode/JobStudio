using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobStudio.Controls;
using WeifenLuo.WinFormsUI.Docking;

namespace JobStudio.Controls
{
    public class Pool:DockContentTemp
    {
        public Panel Flow;
        public Pool()
        {
            //Flow = new Panel { Dock = DockStyle.Fill };
            //Flow.Controls.Add(new Element());
            //Controls.Add(Flow);
            Controls.Add(new Element());
        }


    }
}
