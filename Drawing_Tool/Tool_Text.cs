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
        bool textButtonStart = false;
        bool labelTrasport = false;
        bool textFinish = false;
        Label newLbl;
        TextBox newTxtBx;

        /// <summary>
        /// yeni label ekler. Defalarca eklenen textbox içeriğindeki yazıyı ekrana sabitlemek için
        /// </summary>
        /// <param name="newLabel">yeni label nesnesini gönder</param>
        void newLabel(ref Label newLabel)
        {
            newLabel = new Label();
            newLabel.Text = "metin girişi bekleniyor";
            newLbl.AutoSize = true;
            newLbl.Font = font_inLabel;
            newLbl.ForeColor = _color;
            newLbl.Left = x_yazi_konum;
            newLbl.Top = y_yazi_konum;
            newLbl.MouseDown += _dLabel_MouseDown;
            newLbl.MouseMove += _dLabel_MouseMove;
            newLbl.MouseUp += _dLabel_MouseUp;
            newLbl.Click += _dLabel_Click;
            _picCizimAlani.Controls.Add(newLbl);
        }

        private void _pnlText_MouseClick(object sender, MouseEventArgs e)
        {
            PanelClickEvents(_pnlText, ref textButtonStart, Cursors.IBeam);
            textFinish = false;
            _pnlTextFormatSelect.Visible = true;
        }

        /// <summary>
        /// yeni textbox nesnesi oluşturur. defalarca yazı eklemek için
        /// </summary>
        /// <param name="newTextBox">newTxtBx gönder</param>
        void newTextBox(ref TextBox newTextBox)
        {
            newTextBox = new TextBox();
            newTxtBx.Visible = true;
            newTxtBx.Focus();
            newTxtBx.KeyPress += _dTextBox_KeyPress;
            _picCizimAlani.Controls.Add(newTxtBx);

            this.ActiveControl = newTxtBx;
            newTxtBx.Visible = false;
        }

        int x_yazi_konum;
        int y_yazi_konum;
        void TextMouseDown(MouseEventArgs e)
        {
            x_yazi_konum = e.X;
            y_yazi_konum = e.Y;
            ScreenShot();
            _picCizimAlani.Controls.Remove(newLbl);
            newLabel(ref newLbl);
            newTextBox(ref newTxtBx);
            textFinish = false;
        }

        private void _dLabel_Click(object sender, EventArgs e)
        {
            textFinish = false;//label'a tıkladığında tekrar yazabilsin diye
        }

        private void _dTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!textFinish)
            {
                if (e.KeyChar == (char)13) // enter return
                {
                    textFinish = true;
                    newTxtBx.Text = "";
                    ScreenShot();
                    _picCizimAlani.Controls.Remove(newLbl);
                }
                else
                    newLbl.Text = newTxtBx.Text;
            }
            labelTrasport = false;
        }

        private void _dLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!labelTrasport)
            {
                labelTrasport = true;
                ScreenShot();
                _picCizimAlani.Controls.Remove(newLbl);
                newTxtBx.Text = "";
            }
        }

        private void _dLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (labelTrasport)
            {
                newLbl.Left = newLbl.Left + e.X;
                newLbl.Top = newLbl.Top + e.Y;
                labelTrasport = false;
            }
        }

        private void _dLabel_MouseDown(object sender, EventArgs e)
        {
            labelTrasport = true;
        }

        void TextMouseMove()
        {
            _pnlTextFormatSelect.Visible = false;
        }

        #region Text Format Select Codes
        Font font_inLabel;

        /// <summary>
        /// ComboBox'lara font biçizi stili ve boyutu yükler
        /// </summary>
        void FontFormatStyleLoad()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                _cmbFontFormat.Items.Add(font.Name.ToString());
            }

            foreach (FontStyle style in (FontStyle[])Enum.GetValues(typeof(FontStyle)))
            {
                _cmbFontStyle.Items.Add(style.ToString());
            }

            for (int i = 1; i < 72; i++)
            {
                _cmbFontSize.Items.Add(i.ToString());
            }
            _cmbFontSize.SelectedIndex = 10;
            _cmbFontFormat.SelectedIndex = 1; //combobox chaanged değişimi algılandığı için hata vermemesi açısından en sona yazıyoruz
            _cmbFontStyle.SelectedIndex = 0;
        }

        void Font_inLabel()
        {
            try
            {
                font_inLabel = new Font(_cmbFontFormat.Text, _cmbFontSize.SelectedIndex, (FontStyle)_cmbFontStyle.SelectedIndex);
            }
            catch (Exception)
            {
            }
        }

        private void _cmbFontFormat_TextChanged(object sender, EventArgs e)
        {
            Font_inLabel();
        }

        private void _cmbFontSize_TextChanged(object sender, EventArgs e)
        {
            Font_inLabel();
        }

        private void _cmbFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font_inLabel();
        }

        #endregion
    }
}
