using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{

    public partial class DrawingTool : Form
    {
        bool EllipseButtonStart = false;
        bool EllipseEkle = false;
        bool EllipseBittiMi = false;
        bool EllipseRatio = false;
        private void _pnlEllipse_Click(object sender, EventArgs e)
        {
            PanelClickEvents(_pnlEllipse, ref EllipseButtonStart, Cursors.Cross);
        }

        void EllipseMouseDown(MouseEventArgs e)
        {
            if (EllipseButtonStart == true && e.Button == MouseButtons.Left)
            {
                x_ShapeStart = e.X;
                y_ShapeStart = e.Y;
                EllipseEkle = true;
            }           
        }

        void EllipseMouseMove(MouseEventArgs e)
        {
            _picCizimAlani.Refresh();
            DrawingShape(e, ref EllipseEkle, ref EllipseRatio, ref EllipseBittiMi);
        }
        
        void EllipseMouseUp(MouseEventArgs e)
        {
            DrawingShape(e, ref EllipseEkle, ref EllipseRatio, ref EllipseBittiMi);
            ScreenShot();
        }
        
    }
}
