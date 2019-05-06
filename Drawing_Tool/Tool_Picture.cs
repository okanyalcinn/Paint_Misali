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
        int x_resim_Yeri;
        int y_resim_Yeri;
        bool pictureAddStart = false;
        bool pictureTransport = false;
        bool pictureTransportWhat = false;

        /// <summary>
        /// Sonradan eklenen picturebox nesnesi
        /// </summary>
        PictureBox newPicture;

        /// <summary>
        /// picturebox nesnesini yeniden oluşturmak için metod içerisinde tanımladım. Bu olmaz ise tek bir pictureBox'a sürekli ekleme yapıyormuş gibi oluyor. ekranda dalgalanma oluyor
        /// </summary>
        /// <param name="newPic"></param>
        void pic(ref PictureBox newPic)
        {
            newPic = new PictureBox();
            newPic.Size = new Size(weight, height);
            newPic.SizeMode = PictureBoxSizeMode.StretchImage;
            newPic.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4);
            newPic.MouseDown += NewPicture_MouseDown;
            newPic.MouseMove += NewPicture_MouseMove;
            newPic.MouseUp += NewPicture_MouseUp;
        }

        private void _pnlPictureAdd_Click(object sender, EventArgs e)
        {
            PanelClickEvents(_pnlPictureAdd, ref pictureAddStart, Cursors.SizeAll);
            _pnlPictureSize.Visible = true;
        }

        int weight = 200;
        int height = 180;

        private void _btnPictureSizeOk_Click(object sender, EventArgs e)
        {
            bool inputCorrect = true;
            try
            {
                weight = Int32.Parse(_txtWidht.Text);
                height = Int32.Parse(_txtHeight.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Sayı harici değer girişi yapılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                weight = 200;
                height = 180;
                inputCorrect = false;
            }
            if (inputCorrect)
            {
                pic(ref newPicture);
                OpenFileDialog openPicture = new OpenFileDialog();
                openPicture.Title = "Resim Ekle"; //seçm ekranının başlığı
                saveDialog.Filter = @"Jpeg Dosyaları|*.Jpeg|Png Dosyaları|*.Png ";
                if (openPicture.ShowDialog() == DialogResult.OK)
                {
                    newPicture.Load(openPicture.FileName);
                    _picCizimAlani.Controls.Add(newPicture);
                    _pnlPictureSize.Visible = false;
                }
                PasifYap();
            }
        }

        void PictureSizeMouseMove()
        {
            _pnlPictureSize.Visible = false;
            _pnlPictureAdd.BorderStyle = BorderStyle.None;
            _pnlPictureAdd.BackColor = colorToolNotSelection;
        }

        void NewPicture_MouseDown(object sender, MouseEventArgs e)
        {
            pictureTransport = true;
        }

        Button whatAddButton;
        void btn(ref Button btn)
        {
            btn = new Button();
        }

        void NewPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureTransport)
            {
                btn(ref whatAddButton);
                pictureTransportWhat = true;
                whatAddButton.Visible = false;
                newPicture.Left = newPicture.Left + e.X;
                newPicture.Top = newPicture.Top + e.Y;
            }
        }

        void NewPicture_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureTransportWhat)
            {
                btn(ref whatAddButton);
                whatAddButton.AutoSize = true;
                whatAddButton.Text = "Taşıma işlemi sonlandır";
                whatAddButton.Click += whatAddButton_Click;
                newPicture.Controls.Add(whatAddButton);
                pictureTransport = false;
            }
        }
        void whatAddButton_Click(object sender, EventArgs e)
        {
            whatAddButton.Dispose();
            whatAddButton.Visible = false;
            GC.SuppressFinalize(whatAddButton);
            newPicture.Controls.Remove(whatAddButton);



            _picCizimAlani.Refresh();
            _picCizimAlani.Controls.Remove(newPicture);
            newPicture.Dispose();
            ScreenShot();


            GC.SuppressFinalize(newPicture);//ekrandan görüntüsünü de siler

            _pnlPictureAdd.BorderStyle = BorderStyle.FixedSingle;
            _pnlPictureAdd.BackColor = colorToolNotSelection;
            pictureAddStart = false;
            pictureTransport = false;
            pictureTransportWhat = false;
        }
    }
}
