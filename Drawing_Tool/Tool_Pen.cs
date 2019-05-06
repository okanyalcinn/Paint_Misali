using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{
    public partial class DrawingTool : Form
    {
        bool kalemButtonStart = false;
        bool kalemCizStart = false;
        private void _pnlKalem_Click(object sender, EventArgs e)
        {
//            PasifYap(); //Diğer butonları pasif yap
//            kalemButtonStart = true;
//            _pnlKalem.BorderStyle = BorderStyle.Fixed3D;
//#warning backcolor rengi ayarlayacaksın
//            this.Cursor = Cursors.NoMove2D; //yukarı ok imleci
            PanelClickEvents(_pnlKalem, ref kalemButtonStart, Cursors.NoMove2D);
        }

        void KalemMouseDown()
        {
            if (kalemButtonStart)
            {
                kalemCizStart = true;
            }
        }

        int x_KalemCiz;
        int Y_KalemCiz;

        void KalemMouseMove(MouseEventArgs e)
        {
            Point _baslangicN = new Point(x_KalemCiz, Y_KalemCiz);
            Point _bitisN = new Point(e.X, e.Y); // mouse yeni konumu
            if (kalemCizStart && e.Button == MouseButtons.Left )
            {
                PenTool();
                Graphics _gr = _picCizimAlani.CreateGraphics();
                _gr.DrawLine(pencil, _baslangicN, _bitisN);
                _gr.FillEllipse(new SolidBrush(_color), e.X - _LineSize / 2, e.Y - _LineSize / 2, _LineSize, _LineSize); //kalem,x,y,kalınlık,kalınlık
                _gr.Dispose();                   
            }
            x_KalemCiz = e.X;
            Y_KalemCiz = e.Y;
        }

        void KalemMouseUp()
        {
            ScreenShot(); //önceki yapılan çizimler silinmesin diye
        }
    }
}
