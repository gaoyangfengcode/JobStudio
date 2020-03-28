using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JobStudio.Controls
{
    public class Theme
    {
        
        public Color ThemeColor;
        public Pen ThemePen;
        public SolidBrush ThemeBrush;
        public List<Control> Controls;
        public Theme()
        {
            ThemeColor = Color.FromArgb(12, 34, 76);
            ThemePen = new Pen(ThemeColor);
            ThemeBrush = new SolidBrush(ThemeColor);
            
        }
        public void AddControl(Control control)
        {

            if (Controls==null)
            {
                Controls = new List<Control>();
            }
            control.BackColor = ThemeColor;
            control.ForeColor = Color.White;
            //control.TextAlign = ContentAlignment.MiddleCenter;
        }

    }
}
