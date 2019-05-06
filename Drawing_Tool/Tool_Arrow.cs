using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Drawing_Tool
{
    public partial class DrawingTool : Form
    {
        bool ArrowButtonStart = false;
        bool ArrowEkle = false;
        bool ArrowGeciciBittiMi = false;
        private void _pnlArrow_Click(object sender, EventArgs e)
        {
            PanelClickEvents(_pnlArrow, ref ArrowButtonStart, Cursors.Cross);
        }

        void ArrowMouseDown(MouseEventArgs e)
        {
            if (ArrowButtonStart == true && e.Button == MouseButtons.Left)
            {
                x_ShapeStart = e.X;
                y_ShapeStart = e.Y;
                ArrowEkle = true;
            }         
        }

        void ArrowMouseMove(MouseEventArgs e)
        {
            _picCizimAlani.Refresh();
            DrawingLineAndArrow(e, ref ArrowEkle, ref ArrowButtonStart,ref LineButtonStart);
        }

        void ArrowMouseUp(MouseEventArgs e)
        {
            ArrowGeciciBittiMi = true;
            DrawingLineAndArrow(e, ref ArrowGeciciBittiMi, ref ArrowButtonStart, ref ArrowEkle);
            ScreenShot();
        }


    }
}

