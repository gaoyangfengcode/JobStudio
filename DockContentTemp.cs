using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace JobStudio.Controls
{
    public class DockContentTemp : DockContent
    {
        public DockContentTemp()
        {

        }
        public DockContentTemp(DockPanel pnl,DockState st)
        {
            DockPanel = pnl;
            DockState = st;
            Show();
        }
    }
}
