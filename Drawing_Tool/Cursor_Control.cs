using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{
    public partial class DrawingTool : Form
    {
        

        private void _pnlTools_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default; //el imleci
        }

        /// <summary>
        /// imleç stilini bir önceki imlece çevirir. tool çubuğundan geri dönerken işleme girer
        /// </summary>
        private void Mouse_imleci()
        {
            if (kalemButtonStart)
            {
                this.Cursor = Cursors.NoMove2D; 
            }
            else if (LineButtonStart || RectangleButtonStart||ArrowButtonStart ||EllipseButtonStart)
            {
                this.Cursor = Cursors.Cross; //artı imleci
            }
            else if (textButtonStart)
            {
                this.Cursor = Cursors.IBeam; // yazı imleci
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void _pnlTools_MouseLeave(object sender, EventArgs e)
        {
            Mouse_imleci();
        }

        private void _pnl_icon_MouseLeave(object sender, EventArgs e)
        {
            Mouse_imleci();
        }

        private void _pnlScreenShot_MouseLeave(object sender, EventArgs e)
        {
            Mouse_imleci();
        }

        private void _pnlMasaustu_MouseLeave(object sender, EventArgs e)
        {
            Mouse_imleci();
        }

        private void _pnlCikis_MouseLeave(object sender, EventArgs e)
        {
            Mouse_imleci();
        }
        
           
    }
}
