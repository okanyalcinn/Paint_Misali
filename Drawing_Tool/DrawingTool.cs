using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{
    public partial class DrawingTool : Form
    {
        public DrawingTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// butonları pasif yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pnlCursor_MouseClick(object sender, MouseEventArgs e)
        {
            PasifYap(); //Diğer butonları pasif yap
            _pnlCursor.BorderStyle = BorderStyle.Fixed3D;
            this.Cursor = Cursors.Default;
        }

        private void _pnlMasaustu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _pnlScreenShot_Click(object sender, EventArgs e)
        {
            #region arka plan ekran görüntüsü alma
            _picAbout.Visible = false;
            _picCizimAlani.Refresh();
            SaveChangedWhat("Değişiklikler kaydedilsin mi ?");
            this.Hide();
            _picCizimAlani.Controls.Clear();
            Thread.Sleep(250);
            PasifYap();
            ScreenShot();
            this.Show();
            #endregion
        }

        private void _pnlCikis_Click(object sender, EventArgs e)
        {
            _picAbout.Visible = false;
            if (!whatSaved)
                SaveChangedWhat("Çalışmanız kaydedilsin mi ?");
            this.Hide(); //Environment.Exit(0);
        }

        private void _pnlKaydet_Click(object sender, EventArgs e)
        {
            PasifYap();
            _pnlKaydet.BorderStyle = BorderStyle.Fixed3D;
            _pnlKaydet.BackColor = colorToolSelection;
            Save();
        }

        Bitmap colorBitmap;
        void ColorBitmap(ref Bitmap colorBitmap)
        {
            colorBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics _gr = Graphics.FromImage(colorBitmap);
            _gr.SmoothingMode = SmoothingMode.HighQuality;
        }        

        private void DrawingTool_Load(object sender, EventArgs e)
        {
            ColorBitmap(ref colorBitmap);
            _pnlRenkBtn.BackColor = _color; //başlangıç rengini şuanki renk göstergesine ata
            _LineSize = _trackbrLineSize.Value; //kalınlığı
            _txtLineSize.Text = _trackbrLineSize.Value.ToString();

            _pnlRenkEkran.Visible = false;
            _pnlTextFormatSelect.Visible = false;
            _picCizimAlani.Dock = DockStyle.Fill; 
            _pnlCursor.BorderStyle = BorderStyle.Fixed3D;

            _picCizimAlani.Image= colorBitmap;
            _picCizimAlani.Refresh();
            BackNext(_picCizimAlani);

            FontFormatStyleLoad();
            _imgListScreen.ImageSize = new Size(256, 256);
        }
        
        private void _picCizimAlani_MouseDown(object sender, MouseEventArgs e)
        {
            if (textButtonStart)
                TextMouseDown(e);

            if (kalemButtonStart)
                KalemMouseDown();

            if (LineButtonStart)
                LineMouseDown(e);

            if (RectangleButtonStart)
                RectangleMouseDown(e);

            if (EllipseButtonStart)
                EllipseMouseDown(e);

            if (ArrowButtonStart)
                ArrowMouseDown(e);
            
            if (pictureAddStart)
            {
                x_resim_Yeri = e.X;
                y_resim_Yeri = e.Y;
            }
        }

        private void _picCizimAlani_MouseMove(object sender, MouseEventArgs e)
        {
            if (textButtonStart)
                TextMouseMove();

            if (pictureAddStart)
                PictureSizeMouseMove();

            if (colorButtonStart)
                ColorToolMouseMove();
            
            if (kalemButtonStart)
                KalemMouseMove(e);
            
            if (LineButtonStart)
                LineMouseMove(e);
            
            if (RectangleButtonStart)
                RectangleMouseMove(e);
            
            if (EllipseButtonStart)
                EllipseMouseMove(e);
            
            if (ArrowButtonStart)
                ArrowMouseMove(e);
        }

        int _xBit;
        int _yBit;
        private void _picCizimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            _xBit = e.X;
            _yBit = e.Y;
            if (kalemButtonStart)
                KalemMouseUp();
            
            if (LineButtonStart)
                LineMouseUp(e);
            
            if (RectangleButtonStart)
                RectangleMouseUp(e);
            
            if (EllipseButtonStart)
                EllipseMouseUp(e);
            
            if (ArrowButtonStart)
                ArrowMouseUp(e);            
        }

        private void DrawingTool_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift) //ctrl+shift tuşu basılı ise orantılı çizimi booleen değeri true yap
            {
                RectangleRatio = true;
                EllipseRatio = true;
            }
        }

        private void DrawingTool_KeyUp(object sender, KeyEventArgs e)
        {
            if (RectangleButtonStart || EllipseButtonStart)
            {
                RectangleRatio = false;
                EllipseRatio = false;
            }
        }

        private void _pnlPaintingBucket_MouseClick(object sender, MouseEventArgs e)
        {
#warning önceki çalışmay kaydet sorusu gelecek
            canvasChanged = true;

#warning renk doldurma olmuyor
            _picCizimAlani.Image.Dispose();
            _picCizimAlani = new PictureBox();
            _picCizimAlani.BackColor= Color.Aqua;
            _picCizimAlani.Refresh();
            //ScreenShot();
        }

        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            canvasChanged = false;
        }

        private void _pnl_icon_MouseClick(object sender, MouseEventArgs e)
        {
            PasifYap();
            _picAbout.Dock = DockStyle.Fill;
            _picAbout.SizeMode = PictureBoxSizeMode.CenterImage;
            _picAbout.BackColor = Color.Black;
            _picAbout.Visible = true;
#warning mouse click yapınca visible false yap
        }
    }
}
