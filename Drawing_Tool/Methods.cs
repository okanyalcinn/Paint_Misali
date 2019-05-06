using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Tool
{

    public partial class DrawingTool : Form
    {
        Color colorToolSelection = ColorTranslator.FromHtml("#ff355d");
        Color colorToolNotSelection = ColorTranslator.FromHtml("#dc143c");
        static Color _color = ColorTranslator.FromHtml("#00a551");
        int x_ShapeStart;
        int y_ShapeStart;
        Pen pencil;

        void PenTool()
        {
            pencil = new Pen(_color, _LineSize);
        }

        /// <summary>
        /// Ekran görüntüsünü alır pictureBox'a aktarır
        /// </summary>
        void ScreenShot()
        {
            _picAbout.Visible = false;
            Bitmap _bitmapEkran = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics _gr = Graphics.FromImage(_bitmapEkran);
            _gr.SmoothingMode = SmoothingMode.HighQuality;
            _gr.CopyFromScreen(0, 0, 0, 0, _bitmapEkran.Size);
            _picCizimAlani.Image = _bitmapEkran;
            _picCizimAlani.Refresh();
            BackNext(_picCizimAlani);
            canvasChanged = true;
        }

        #region çalışma kayıt methodları
        bool whatSaved = false;
        SaveFileDialog saveDialog = new SaveFileDialog();
        ImageFormat imageFormat = null;
        /// <summary>
        /// PictureBox çalışma alanının kaydedileceği yeri seçme işlemi yapar
        /// </summary>
        void Save()
        {
            _picAbout.Visible = false;
            whatSaved = true;
            ScreenShot();
            saveDialog.Title = "Çalışma Tuvalini Kaydet";
            saveDialog.Filter = @"Jpeg Dosyaları|*.Jpeg|Png Dosyaları|*.Png ";
            saveDialog.DefaultExt = "Jpeg";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string yol = saveDialog.FileName;
                string uzanti = yol.Substring(yol.LastIndexOf('.'));
                saveDialog.OverwritePrompt = true;
                saveDialog.CreatePrompt = false;
                switch (uzanti)
                {
                    case ".Jpeg": imageFormat = ImageFormat.Jpeg; break;
                    case ".Png": imageFormat = ImageFormat.Png; break;
                }
                if (canvasChanged) // metinbox düzenlendiyse
                {
                    SaveRecord(saveDialog, imageFormat);
                }
                else
                {
                    MessageBox.Show("Tuval üzerinde bir değişiklik yok", "Değişiklik yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PasifYap();
        }

        /// <summary>
        /// PictureBox'ı dosya yoluna kaydet
        /// </summary>
        void SaveRecord(SaveFileDialog saveDialog, ImageFormat imageFormat)
        {
            try
            {
                _picCizimAlani.Image.Save(saveDialog.FileName);
                MessageBox.Show("Çalışmanız başırılı bir şekilde kaydedildi", "Dosya Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Birşey oldu!" + ex);
            }
        }

        /// <summary>
        /// Tuval alanında değişiklik var mı ?
        /// </summary>
        bool canvasChanged = false;

        /// <summary>
        /// PictureBox tuvalinde herhangi bir değişiklik olup olmadığını kontrol edip. değişikliği kaydet sorusu yöneltir
        /// </summary>
        /// <param name="mesaj"></param>
        private void SaveChangedWhat(string mesaj)
        {
            if (canvasChanged) // metinbox düzenlendiyse
            {
                DialogResult result = MessageBox.Show(mesaj, "Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
        }
        #endregion

        #region seçilmiş butonu etkin kılma & diğer seçilmemiş butonları pasif yapma
        /// <summary>
        /// seçilen buton işlevli panelin hangi kodları uygulayacağını karar kılar
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="start"></param>
        void PanelClickEvents(Panel panel, ref bool start, Cursor cursor)
        {
            PasifYap(); //Diğer butonları pasif yap
            start = true;
            panel.BorderStyle = BorderStyle.Fixed3D;
            this.Cursor = cursor;
            panel.BackColor = colorToolSelection;
        }

        /// <summary>
        /// panel secimlerini pasif yapar
        /// </summary>
        void PasifYap()
        {
            _picAbout.Visible = false;
            _picCizimAlani.Refresh();
            _pnlCursor.BorderStyle = BorderStyle.FixedSingle;
            _pnlCursor.BackColor = colorToolNotSelection;
            LineButtonStart = false;

            _pnlText.BorderStyle = BorderStyle.FixedSingle;
            _pnlText.BackColor = colorToolNotSelection;
            textButtonStart = false;
            //textFinish = true;
            labelTrasport = false;

            _pnlLine.BorderStyle = BorderStyle.FixedSingle;
            _pnlLine.BackColor = colorToolNotSelection;
            LineButtonStart = false;

            _pnlArrow.BorderStyle = BorderStyle.FixedSingle;
            _pnlArrow.BackColor = colorToolNotSelection;
            ArrowButtonStart = false;

            _pnlKalem.BorderStyle = BorderStyle.FixedSingle;
            _pnlKalem.BackColor = colorToolNotSelection;
            kalemButtonStart = false;
            kalemCizStart = false;

            _pnlRectagle.BorderStyle = BorderStyle.FixedSingle;
            _pnlRectagle.BackColor = colorToolNotSelection;
            RectangleButtonStart = false;

            _pnlEllipse.BorderStyle = BorderStyle.FixedSingle;
            _pnlEllipse.BackColor = colorToolNotSelection;
            EllipseButtonStart = false;

            _pnlPictureAdd.BorderStyle = BorderStyle.FixedSingle;
            _pnlPictureAdd.BackColor = colorToolNotSelection;
            pictureAddStart = false;
            pictureTransport = false;
            pictureTransportWhat = false;

            _pnlRenkEkran.BorderStyle = BorderStyle.FixedSingle;
            _pnlRenkEkran.BackColor = colorToolNotSelection;
            birdahaCekme = false;

            _pnlKaydet.BorderStyle = BorderStyle.FixedSingle;
            _pnlKaydet.BackColor = colorToolNotSelection;
        }
        #endregion

        #region ileri geri alma methodları
        int lastAdded_index = 0;
        int nextLastAdded_index = 0;
        Bitmap[] bitmapBackNextData = new Bitmap[100];
        /// <summary>
        /// En son yapılan çizimleri screenshot'tan sonra dizi içerisinde hafızaya alır
        /// </summary>
        /// <param name="cizim"></param>
        void BackNext(PictureBox cizim)
        {
            for (int i = 0; i < bitmapBackNextData.Length; i++)
            {
                if (bitmapBackNextData[i] == null)
                {
                    bitmapBackNextData[i] = new Bitmap(cizim.Image, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    lastAdded_index = i;
                    break;
                }
            }
        }

        private void _pnlBack_Click(object sender, EventArgs e)
        {
            _picAbout.Visible = false;
            if (lastAdded_index >= 0 && canvasChanged && bitmapBackNextData[lastAdded_index] != null)
            {
                if (lastAdded_index == 0)
                {
                    lastAdded_index = 1;
                }
                _picCizimAlani.Image = bitmapBackNextData[lastAdded_index - 1];
                lastAdded_index--;
                nextLastAdded_index++;
            }
        }

        private void _pnlNext_MouseClick(object sender, MouseEventArgs e)
        {
            _picAbout.Visible = false;
            if (lastAdded_index >= 0 && canvasChanged && nextLastAdded_index > 0 && bitmapBackNextData[lastAdded_index + 1] != null)
            {
                _picCizimAlani.Image = bitmapBackNextData[lastAdded_index + 1];
                lastAdded_index++;
                nextLastAdded_index--;
            }
        }
        #endregion

        #region çizim methodları
        /// <summary>
        /// düz çubuk çizimi veya ok çizimi yapar
        /// </summary>
        /// <param name="e">mouse hareketleri</param>
        /// <param name="add">eklensin mi</param>
        /// <param name="arrowStart">ok çizimi mi</param>
        /// <param name="finishAdd">bitti mi (gecici çizim için anlamsız birşey gönder)</param>
        void DrawingLineAndArrow(MouseEventArgs e, ref bool add, ref bool arrowStart, ref bool finishAdd)
        {
            PenTool();
            if (add == true && e.Button == MouseButtons.Left)
            {
                Graphics _grCizgiGecici = _picCizimAlani.CreateGraphics();
                if (arrowStart)
                {
                    pencil.StartCap = LineCap.Flat;
                    pencil.EndCap = LineCap.ArrowAnchor;
                }
                _grCizgiGecici.DrawLine(pencil, x_ShapeStart, y_ShapeStart, e.X, e.Y);//başlangıç x, y | bitiş x,y
                finishAdd = false;
                //add = false;
            }
        }

        /// <summary>
        /// Çizim aşamasının ilk kontrolüdür. orantılı olup olmadığının kontrolü sağlanır
        /// </summary>
        /// <param name="e"></param>
        /// <param name="add">eklensin mi</param>
        /// <param name="ratio"> orantılı mı</param>
        /// <param name="finish"> bitti mi</param>
        void DrawingShape(MouseEventArgs e, ref bool add, ref bool ratio, ref bool finish)
        {
            PenTool();
            if (add == true && e.Button == MouseButtons.Left)
            {
                if (ratio == true)
                    DrawingShape(e, x_ShapeStart, ref finish);
                else
                    DrawingShape(e, x_ShapeStart, y_ShapeStart, ref finish);
                canvasChanged = true;
            }
        }

        /// <summary>
        /// Mouse Move ile orantılı çizim yapar
        /// </summary>
        /// <param name="e">MouseEventArgs parametresi</param>
        /// <param name="x_y_ratio">mouse x konumu orantılı cizim icin tek konum</param>
        /// <param name="finish">bitti mi</param>   
        void DrawingShape(MouseEventArgs e, int x_y_ratio, ref bool finish)
        {
            Graphics _grRectangle = _picCizimAlani.CreateGraphics();
            if (RectangleButtonStart)
                _grRectangle.DrawRectangle(pencil, x_ShapeStart, y_ShapeStart, e.X - x_y_ratio, e.X - x_y_ratio);
            else if (EllipseButtonStart)
                _grRectangle.DrawEllipse(pencil, x_ShapeStart, y_ShapeStart, e.X - x_y_ratio, e.X - x_y_ratio);
            finish = true;
            _grRectangle.Dispose();
        }

        /// <summary>
        /// Mouse Move ile orantısız çizim yapar
        /// </summary>
        /// <param name="e">MouseEventArgs parametresi</param>
        /// <param name="x_ShapeFinish">mouese move x konumu</param>
        /// <param name="y_ShapeFinish">mouse move y konumu</param>
        /// <param name="finish">bitti mi</param>       
        void DrawingShape(MouseEventArgs e, int x_ShapeFinish, int y_ShapeFinish, ref bool finish)
        {
            Graphics _grRectangle = _picCizimAlani.CreateGraphics();
            if (RectangleButtonStart)
                _grRectangle.DrawRectangle(pencil, x_ShapeStart, y_ShapeStart, e.X - x_ShapeFinish, e.Y - y_ShapeFinish);
            else if (EllipseButtonStart)
                _grRectangle.DrawEllipse(pencil, x_ShapeStart, y_ShapeStart, e.X - x_ShapeFinish, e.Y - y_ShapeFinish);
            finish = true;
            _grRectangle.Dispose();
        }
        #endregion
    }
}
