using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStudio.Controls
{
    public class Element : Label
    {
        public Element ParentElement;
        public ContextMenuStrip CtxMenu;
        public Theme NewTheme;
        public int deltX;
        public int deltY;
        public int VGap = 10;
        public int HGap;
        public Element()
        {
            var siz = SystemInformation.DragSize;
            Size = new Size(100, 100);
            NewTheme = new Theme();
            NewTheme.AddControl(this);
            //Margin = new Padding(10);
            //DoubleBuffered = true;
            CtxMenu = new ContextMenuStrip();
            var CtxAddItem = CtxMenu.Items.Add("子项", JobStudio.Properties.Resources.Image1);
            {
                //MouseHover += (object sender, EventArgs e) => { CtxMenu.Show(Cursor.Position); };
                //Click += (object sender, EventArgs e) => { CtxMenu.Hide(); };
                //CtxAddItem.Click += Element_DoubleClick;
            }
            //MouseHover += Element_MouseHover;
            MouseDown += Element_MouseDown;
            DragOver += Element_DragOver;
            QueryContinueDrag += Element_QueryContinueDrag;
            DragLeave += Element_DragLeave;
            //DragDrop += Element_DragDrop;

        }

        private void Element_DragOver(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Element_MouseHover(object sender, EventArgs e)
        {
        }

        private void Element_MouseDown(object sender, MouseEventArgs e)
        {
            
            deltX = Cursor.Position.X - Location.X;
            deltY = Cursor.Position.Y - Location.Y;
            DoDragDrop(Location, DragDropEffects.Move);
        }

        private void Element_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Location = new Point(Cursor.Position.X - deltX, Cursor.Position.Y - deltY);
        }
        private void Element_DragLeave(object sender,EventArgs e)
        {
            GiveFeedback += Element_GiveFeedback;
        }

        private void Element_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            
        }

        private void Element_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Element_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
