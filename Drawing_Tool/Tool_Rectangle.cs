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
        bool RectangleButtonStart = false;
        bool RectangleEkle = false;
        bool RectangleBittiMi = false;
        bool RectangleRatio = false;
        private void _pnlRectagle_Click(object sender, EventArgs e)
        {
            PanelClickEvents(_pnlRectagle, ref RectangleButtonStart, Cursors.Cross);
        }
        
        void RectangleMouseDown(MouseEventArgs e)
        {
            #region dikdörtgen Ekleme Down
            if (RectangleButtonStart == true && e.Button == MouseButtons.Left)
            {
                x_ShapeStart = e.X;
                y_ShapeStart = e.Y;
                RectangleEkle = true;
            }
            #endregion            
        }

        void RectangleMouseMove(MouseEventArgs e)
        {
            _picCizimAlani.Refresh();
            DrawingShape(e, ref RectangleEkle, ref RectangleRatio, ref RectangleBittiMi);
        }

        void RectangleMouseUp(MouseEventArgs e)
        {
            DrawingShape(e, ref RectangleEkle, ref RectangleRatio, ref RectangleBittiMi);
            ScreenShot();
        }

        
    }
}
