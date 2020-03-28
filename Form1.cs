using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobStudio.Controls;
using WeifenLuo.WinFormsUI.Docking;
namespace JobStudio
{
    public partial class Form1 : Form
    {
        private readonly Pool ElementsPool;
        public Form1()
        {
            InitializeComponent();
            ElementsPool = new Pool { DockPanel = Content, DockState = DockState.Document,VisibleState= DockState.DockLeft};
            Content.Controls.Add(ElementsPool);
            //ElementsPool.Show(Content, DockState.Document);
           
            //ElementsPool.Invalidate(true);
            
        }
    }
}
