using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicStudio.Controls;
using MagicStudio.Drawing;

namespace MagicStudio
{
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {

            InitializeComponent();
            var modelSpace1 = new Paper()
            {
            };
            Controls.Add(modelSpace1);
        }
    }
}
