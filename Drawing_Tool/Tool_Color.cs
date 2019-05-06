using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{
    public partial class DrawingTool : Form
    {
        bool colorButtonStart = false;
        bool birdahaCekme = false;
        private void _pnlRenkBtn_Click(object sender, EventArgs e)
        {
            _picAbout.Visible = false;
            _picCizimAlani.Refresh();
            if (!birdahaCekme)
            {
                ScreenShot();
                birdahaCekme = true;
            }            
            PasifYap(); //Diğer butonları pasif yap
            colorButtonStart = true;
            _pnlRenkBtn.BorderStyle = BorderStyle.Fixed3D;
            _pnlRenkBtn.Cursor= Cursors.Default;
            _pnlRenkEkran.Visible = true;
            birdahaCekme = true;
        }

        void ColorToolMouseMove()
        {
            _pnlRenkEkran.Visible = false;
            _pnlRenkBtn.BorderStyle = BorderStyle.None;
        }

        private void _pnlRenkBtn_MouseMove(object sender, MouseEventArgs e)
        {
            //ScreenShot();
            //_pnlRenkEkran.Visible = true;
            //_pnlRenkEkran.Dock = DockStyle.Right;
        }
        static int LineSize { get; set; }
        public int _LineSize
        {
            get
            {
                if (LineSize < 1 || LineSize > 41)
                {
                    return 5;
                }
                else
                {
                    return LineSize;
                }
            }
            set
            {
                if (value < 1 || value > 41)
                {
                    LineSize = 5;
                }
                else
                {
                    LineSize = value;
                }
            }
        }

        private void _picRenkPaleti_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap _btmpRenk = new Bitmap(_picRenkPaleti.Image);
            try
            {
                _color = Color.FromArgb(255, _btmpRenk.GetPixel(e.X, e.Y));//_bt.GetPixel() bulunduğu konumdaki rengin HEX kodunu alır
                _pnlRenkBtn.BackColor = _color;
                
            }
            catch (Exception)
            {
            }
        }

        private void _trackbrLineSize_MouseUp(object sender, MouseEventArgs e)
        {
            _LineSize = _trackbrLineSize.Value; //kalınlığı
            _txtLineSize.Text = _trackbrLineSize.Value.ToString();
        }
        
        
        private void _txtLineSize_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(_txtLineSize.Text) > 0 && Convert.ToInt32(_txtLineSize.Text) < 42)
                {
                    _LineSize = int.Parse(_txtLineSize.Text);
                    _trackbrLineSize.Value = _LineSize;
                }
                else
                {
                    MessageBox.Show("1 ile 41 arasında bir değer girişi yapınız");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("1 ile 41 arasında bir değer girişi yapınız");
            }
        }

    }
}
