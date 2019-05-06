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
        

        bool LineButtonStart = false;
        bool LineEkle = false;
        bool LineGeciciBittiMi = false;
        private void _pnlLine_Click(object sender, EventArgs e)
        {
            PanelClickEvents(_pnlLine, ref LineButtonStart, Cursors.Cross);
        }

        void LineMouseDown(MouseEventArgs e)
        {
            if (LineButtonStart == true && e.Button == MouseButtons.Left)
            {
                x_ShapeStart = e.X;
                y_ShapeStart = e.Y;
                LineEkle = true;
            }        
        }

        void LineMouseMove(MouseEventArgs e)
        {
            _picCizimAlani.Refresh();
            DrawingLineAndArrow(e, ref LineEkle, ref ArrowButtonStart, ref ArrowButtonStart);
        }

        void LineMouseUp(MouseEventArgs e)
        {
            LineGeciciBittiMi = true;
            DrawingLineAndArrow(e, ref LineGeciciBittiMi, ref ArrowButtonStart, ref LineEkle);
            ScreenShot();
            BackNext(_picCizimAlani);
        }
    }
}
