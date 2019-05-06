namespace Drawing_Tool
{
    partial class DrawingTool
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingTool));
            this._pnlTools = new System.Windows.Forms.Panel();
            this._pnlNext = new System.Windows.Forms.Panel();
            this._pnlBack = new System.Windows.Forms.Panel();
            this._pnlKaydet = new System.Windows.Forms.Panel();
            this._pnlPictureAdd = new System.Windows.Forms.Panel();
            this._pnlPaintingBucket = new System.Windows.Forms.Panel();
            this._pnlSettings = new System.Windows.Forms.Panel();
            this._pnlArrow = new System.Windows.Forms.Panel();
            this._pnlEllipse = new System.Windows.Forms.Panel();
            this._pnlRectagle = new System.Windows.Forms.Panel();
            this._pnlRenkBtn = new System.Windows.Forms.Panel();
            this._pnlKalem = new System.Windows.Forms.Panel();
            this._pnlLine = new System.Windows.Forms.Panel();
            this._pnlScreenShot = new System.Windows.Forms.Panel();
            this._pnlMasaustu = new System.Windows.Forms.Panel();
            this._pnlText = new System.Windows.Forms.Panel();
            this._pnlCikis = new System.Windows.Forms.Panel();
            this._pnlCursor = new System.Windows.Forms.Panel();
            this._pnl_icon = new System.Windows.Forms.Panel();
            this._pnlCizimAlani = new System.Windows.Forms.Panel();
            this._picAbout = new System.Windows.Forms.PictureBox();
            this._pnlRenkEkran = new System.Windows.Forms.Panel();
            this._txtLineSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._picRenkPaleti = new System.Windows.Forms.PictureBox();
            this._trackbrLineSize = new System.Windows.Forms.TrackBar();
            this._pnlPictureSize = new System.Windows.Forms.Panel();
            this._btnPictureSizeOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._txtHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtWidht = new System.Windows.Forms.TextBox();
            this._pnlTextFormatSelect = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbFontStyle = new System.Windows.Forms.ComboBox();
            this._cmbFontSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cmbFontFormat = new System.Windows.Forms.ComboBox();
            this._picCizimAlani = new System.Windows.Forms.PictureBox();
            this._toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this._imgListScreen = new System.Windows.Forms.ImageList(this.components);
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._pnlTools.SuspendLayout();
            this._pnlCizimAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picAbout)).BeginInit();
            this._pnlRenkEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picRenkPaleti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._trackbrLineSize)).BeginInit();
            this._pnlPictureSize.SuspendLayout();
            this._pnlTextFormatSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picCizimAlani)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlTools
            // 
            this._pnlTools.BackColor = System.Drawing.Color.Crimson;
            this._pnlTools.Controls.Add(this._pnlNext);
            this._pnlTools.Controls.Add(this._pnlBack);
            this._pnlTools.Controls.Add(this._pnlKaydet);
            this._pnlTools.Controls.Add(this._pnlPictureAdd);
            this._pnlTools.Controls.Add(this._pnlPaintingBucket);
            this._pnlTools.Controls.Add(this._pnlSettings);
            this._pnlTools.Controls.Add(this._pnlArrow);
            this._pnlTools.Controls.Add(this._pnlEllipse);
            this._pnlTools.Controls.Add(this._pnlRectagle);
            this._pnlTools.Controls.Add(this._pnlRenkBtn);
            this._pnlTools.Controls.Add(this._pnlKalem);
            this._pnlTools.Controls.Add(this._pnlLine);
            this._pnlTools.Controls.Add(this._pnlScreenShot);
            this._pnlTools.Controls.Add(this._pnlMasaustu);
            this._pnlTools.Controls.Add(this._pnlText);
            this._pnlTools.Controls.Add(this._pnlCikis);
            this._pnlTools.Controls.Add(this._pnlCursor);
            this._pnlTools.Controls.Add(this._pnl_icon);
            this._pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnlTools.Location = new System.Drawing.Point(0, 449);
            this._pnlTools.Name = "_pnlTools";
            this._pnlTools.Size = new System.Drawing.Size(963, 44);
            this._pnlTools.TabIndex = 0;
            this._pnlTools.MouseLeave += new System.EventHandler(this._pnlTools_MouseLeave);
            this._pnlTools.MouseMove += new System.Windows.Forms.MouseEventHandler(this._pnlTools_MouseMove);
            // 
            // _pnlNext
            // 
            this._pnlNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlNext.BackgroundImage")));
            this._pnlNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlNext.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlNext.Location = new System.Drawing.Point(484, 0);
            this._pnlNext.Name = "_pnlNext";
            this._pnlNext.Size = new System.Drawing.Size(47, 44);
            this._pnlNext.TabIndex = 10;
            this._toolTip_info.SetToolTip(this._pnlNext, "İleri Al");
            this._pnlNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pnlNext_MouseClick);
            // 
            // _pnlBack
            // 
            this._pnlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlBack.BackgroundImage")));
            this._pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlBack.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlBack.Location = new System.Drawing.Point(437, 0);
            this._pnlBack.Name = "_pnlBack";
            this._pnlBack.Size = new System.Drawing.Size(47, 44);
            this._pnlBack.TabIndex = 9;
            this._toolTip_info.SetToolTip(this._pnlBack, "Geri Al");
            this._pnlBack.Click += new System.EventHandler(this._pnlBack_Click);
            // 
            // _pnlKaydet
            // 
            this._pnlKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlKaydet.BackgroundImage")));
            this._pnlKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlKaydet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlKaydet.Location = new System.Drawing.Point(628, 0);
            this._pnlKaydet.Name = "_pnlKaydet";
            this._pnlKaydet.Size = new System.Drawing.Size(47, 44);
            this._pnlKaydet.TabIndex = 11;
            this._toolTip_info.SetToolTip(this._pnlKaydet, "Tuval Kaydedici");
            this._pnlKaydet.Click += new System.EventHandler(this._pnlKaydet_Click);
            // 
            // _pnlPictureAdd
            // 
            this._pnlPictureAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlPictureAdd.BackgroundImage")));
            this._pnlPictureAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlPictureAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlPictureAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlPictureAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlPictureAdd.Location = new System.Drawing.Point(675, 0);
            this._pnlPictureAdd.Name = "_pnlPictureAdd";
            this._pnlPictureAdd.Size = new System.Drawing.Size(47, 44);
            this._pnlPictureAdd.TabIndex = 12;
            this._toolTip_info.SetToolTip(this._pnlPictureAdd, "Tuvale Resim Ekle");
            this._pnlPictureAdd.Click += new System.EventHandler(this._pnlPictureAdd_Click);
            // 
            // _pnlPaintingBucket
            // 
            this._pnlPaintingBucket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlPaintingBucket.BackgroundImage")));
            this._pnlPaintingBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlPaintingBucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlPaintingBucket.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlPaintingBucket.Location = new System.Drawing.Point(390, 0);
            this._pnlPaintingBucket.Name = "_pnlPaintingBucket";
            this._pnlPaintingBucket.Size = new System.Drawing.Size(47, 44);
            this._pnlPaintingBucket.TabIndex = 8;
            this._pnlPaintingBucket.Visible = false;
            this._pnlPaintingBucket.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pnlPaintingBucket_MouseClick);
            // 
            // _pnlSettings
            // 
            this._pnlSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlSettings.BackgroundImage")));
            this._pnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlSettings.Location = new System.Drawing.Point(722, 0);
            this._pnlSettings.Name = "_pnlSettings";
            this._pnlSettings.Size = new System.Drawing.Size(47, 44);
            this._pnlSettings.TabIndex = 13;
            this._toolTip_info.SetToolTip(this._pnlSettings, "Ayarlar");
            this._pnlSettings.Visible = false;
            // 
            // _pnlArrow
            // 
            this._pnlArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlArrow.BackgroundImage")));
            this._pnlArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlArrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlArrow.Location = new System.Drawing.Point(343, 0);
            this._pnlArrow.Name = "_pnlArrow";
            this._pnlArrow.Size = new System.Drawing.Size(47, 44);
            this._pnlArrow.TabIndex = 7;
            this._toolTip_info.SetToolTip(this._pnlArrow, "Ok");
            this._pnlArrow.Click += new System.EventHandler(this._pnlArrow_Click);
            // 
            // _pnlEllipse
            // 
            this._pnlEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlEllipse.BackgroundImage")));
            this._pnlEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlEllipse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlEllipse.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlEllipse.Location = new System.Drawing.Point(296, 0);
            this._pnlEllipse.Name = "_pnlEllipse";
            this._pnlEllipse.Size = new System.Drawing.Size(47, 44);
            this._pnlEllipse.TabIndex = 6;
            this._toolTip_info.SetToolTip(this._pnlEllipse, "Elips (Yuvarlak için Ctrl+Shift)");
            this._pnlEllipse.Click += new System.EventHandler(this._pnlEllipse_Click);
            // 
            // _pnlRectagle
            // 
            this._pnlRectagle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlRectagle.BackgroundImage")));
            this._pnlRectagle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlRectagle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlRectagle.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlRectagle.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlRectagle.Location = new System.Drawing.Point(249, 0);
            this._pnlRectagle.Name = "_pnlRectagle";
            this._pnlRectagle.Size = new System.Drawing.Size(47, 44);
            this._pnlRectagle.TabIndex = 5;
            this._toolTip_info.SetToolTip(this._pnlRectagle, "Dikdörtgen (Kare için Ctrl+Shift)");
            this._pnlRectagle.Click += new System.EventHandler(this._pnlRectagle_Click);
            // 
            // _pnlRenkBtn
            // 
            this._pnlRenkBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlRenkBtn.BackgroundImage")));
            this._pnlRenkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlRenkBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlRenkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlRenkBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlRenkBtn.Location = new System.Drawing.Point(769, 0);
            this._pnlRenkBtn.Name = "_pnlRenkBtn";
            this._pnlRenkBtn.Size = new System.Drawing.Size(47, 44);
            this._pnlRenkBtn.TabIndex = 14;
            this._toolTip_info.SetToolTip(this._pnlRenkBtn, "Renk ve Boyut Ayarları");
            this._pnlRenkBtn.Click += new System.EventHandler(this._pnlRenkBtn_Click);
            this._pnlRenkBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this._pnlRenkBtn_MouseMove);
            // 
            // _pnlKalem
            // 
            this._pnlKalem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlKalem.BackgroundImage")));
            this._pnlKalem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlKalem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlKalem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlKalem.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlKalem.Location = new System.Drawing.Point(202, 0);
            this._pnlKalem.Name = "_pnlKalem";
            this._pnlKalem.Size = new System.Drawing.Size(47, 44);
            this._pnlKalem.TabIndex = 4;
            this._toolTip_info.SetToolTip(this._pnlKalem, "Kalem");
            this._pnlKalem.Click += new System.EventHandler(this._pnlKalem_Click);
            // 
            // _pnlLine
            // 
            this._pnlLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlLine.BackgroundImage")));
            this._pnlLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlLine.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlLine.Location = new System.Drawing.Point(155, 0);
            this._pnlLine.Name = "_pnlLine";
            this._pnlLine.Size = new System.Drawing.Size(47, 44);
            this._pnlLine.TabIndex = 5;
            this._toolTip_info.SetToolTip(this._pnlLine, "Düz Çizgi");
            this._pnlLine.Click += new System.EventHandler(this._pnlLine_Click);
            // 
            // _pnlScreenShot
            // 
            this._pnlScreenShot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlScreenShot.BackgroundImage")));
            this._pnlScreenShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlScreenShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlScreenShot.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlScreenShot.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlScreenShot.Location = new System.Drawing.Point(816, 0);
            this._pnlScreenShot.Name = "_pnlScreenShot";
            this._pnlScreenShot.Size = new System.Drawing.Size(47, 44);
            this._pnlScreenShot.TabIndex = 6;
            this._toolTip_info.SetToolTip(this._pnlScreenShot, "Masaüstü ekran görütüsü");
            this._pnlScreenShot.Click += new System.EventHandler(this._pnlScreenShot_Click);
            this._pnlScreenShot.MouseLeave += new System.EventHandler(this._pnlScreenShot_MouseLeave);
            // 
            // _pnlMasaustu
            // 
            this._pnlMasaustu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlMasaustu.BackgroundImage")));
            this._pnlMasaustu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlMasaustu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlMasaustu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlMasaustu.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlMasaustu.Location = new System.Drawing.Point(863, 0);
            this._pnlMasaustu.Name = "_pnlMasaustu";
            this._pnlMasaustu.Size = new System.Drawing.Size(47, 44);
            this._pnlMasaustu.TabIndex = 15;
            this._toolTip_info.SetToolTip(this._pnlMasaustu, "Simge Durumuna Küçült");
            this._pnlMasaustu.Click += new System.EventHandler(this._pnlMasaustu_Click);
            this._pnlMasaustu.MouseLeave += new System.EventHandler(this._pnlMasaustu_MouseLeave);
            // 
            // _pnlText
            // 
            this._pnlText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlText.BackgroundImage")));
            this._pnlText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlText.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlText.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlText.Location = new System.Drawing.Point(111, 0);
            this._pnlText.Name = "_pnlText";
            this._pnlText.Size = new System.Drawing.Size(44, 44);
            this._pnlText.TabIndex = 3;
            this._toolTip_info.SetToolTip(this._pnlText, "Metin Girişi");
            this._pnlText.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pnlText_MouseClick);
            // 
            // _pnlCikis
            // 
            this._pnlCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlCikis.BackgroundImage")));
            this._pnlCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlCikis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlCikis.Location = new System.Drawing.Point(910, 0);
            this._pnlCikis.Name = "_pnlCikis";
            this._pnlCikis.Size = new System.Drawing.Size(53, 44);
            this._pnlCikis.TabIndex = 16;
            this._toolTip_info.SetToolTip(this._pnlCikis, "Çıkış");
            this._pnlCikis.Click += new System.EventHandler(this._pnlCikis_Click);
            this._pnlCikis.MouseLeave += new System.EventHandler(this._pnlCikis_MouseLeave);
            // 
            // _pnlCursor
            // 
            this._pnlCursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnlCursor.BackgroundImage")));
            this._pnlCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlCursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlCursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnlCursor.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlCursor.Location = new System.Drawing.Point(64, 0);
            this._pnlCursor.Name = "_pnlCursor";
            this._pnlCursor.Size = new System.Drawing.Size(47, 44);
            this._pnlCursor.TabIndex = 2;
            this._toolTip_info.SetToolTip(this._pnlCursor, "İşaretçi");
            this._pnlCursor.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pnlCursor_MouseClick);
            // 
            // _pnl_icon
            // 
            this._pnl_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_pnl_icon.BackgroundImage")));
            this._pnl_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pnl_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnl_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pnl_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnl_icon.Location = new System.Drawing.Point(0, 0);
            this._pnl_icon.Name = "_pnl_icon";
            this._pnl_icon.Size = new System.Drawing.Size(64, 44);
            this._pnl_icon.TabIndex = 1;
            this._toolTip_info.SetToolTip(this._pnl_icon, "Program Hakkında");
            this._pnl_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pnl_icon_MouseClick);
            this._pnl_icon.MouseLeave += new System.EventHandler(this._pnl_icon_MouseLeave);
            // 
            // _pnlCizimAlani
            // 
            this._pnlCizimAlani.Controls.Add(this._picAbout);
            this._pnlCizimAlani.Controls.Add(this._pnlRenkEkran);
            this._pnlCizimAlani.Controls.Add(this._pnlPictureSize);
            this._pnlCizimAlani.Controls.Add(this._pnlTextFormatSelect);
            this._pnlCizimAlani.Controls.Add(this._picCizimAlani);
            this._pnlCizimAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlCizimAlani.Location = new System.Drawing.Point(0, 0);
            this._pnlCizimAlani.Name = "_pnlCizimAlani";
            this._pnlCizimAlani.Size = new System.Drawing.Size(963, 449);
            this._pnlCizimAlani.TabIndex = 1;
            // 
            // _picAbout
            // 
            this._picAbout.Image = ((System.Drawing.Image)(resources.GetObject("_picAbout.Image")));
            this._picAbout.Location = new System.Drawing.Point(155, 12);
            this._picAbout.Name = "_picAbout";
            this._picAbout.Size = new System.Drawing.Size(197, 129);
            this._picAbout.TabIndex = 11;
            this._picAbout.TabStop = false;
            this._picAbout.Visible = false;
            // 
            // _pnlRenkEkran
            // 
            this._pnlRenkEkran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlRenkEkran.BackColor = System.Drawing.Color.Crimson;
            this._pnlRenkEkran.Controls.Add(this._txtLineSize);
            this._pnlRenkEkran.Controls.Add(this.label1);
            this._pnlRenkEkran.Controls.Add(this._picRenkPaleti);
            this._pnlRenkEkran.Controls.Add(this._trackbrLineSize);
            this._pnlRenkEkran.Location = new System.Drawing.Point(722, 169);
            this._pnlRenkEkran.Name = "_pnlRenkEkran";
            this._pnlRenkEkran.Size = new System.Drawing.Size(225, 280);
            this._pnlRenkEkran.TabIndex = 1;
            // 
            // _txtLineSize
            // 
            this._txtLineSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtLineSize.Location = new System.Drawing.Point(186, 203);
            this._txtLineSize.Name = "_txtLineSize";
            this._txtLineSize.Size = new System.Drawing.Size(27, 20);
            this._txtLineSize.TabIndex = 7;
            this._txtLineSize.Tag = "";
            this._txtLineSize.TextChanged += new System.EventHandler(this._txtLineSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Boyut:";
            // 
            // _picRenkPaleti
            // 
            this._picRenkPaleti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._picRenkPaleti.Cursor = System.Windows.Forms.Cursors.Hand;
            this._picRenkPaleti.Dock = System.Windows.Forms.DockStyle.Top;
            this._picRenkPaleti.Image = ((System.Drawing.Image)(resources.GetObject("_picRenkPaleti.Image")));
            this._picRenkPaleti.Location = new System.Drawing.Point(0, 0);
            this._picRenkPaleti.Name = "_picRenkPaleti";
            this._picRenkPaleti.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._picRenkPaleti.Size = new System.Drawing.Size(225, 197);
            this._picRenkPaleti.TabIndex = 5;
            this._picRenkPaleti.TabStop = false;
            this._picRenkPaleti.MouseDown += new System.Windows.Forms.MouseEventHandler(this._picRenkPaleti_MouseDown);
            // 
            // _trackbrLineSize
            // 
            this._trackbrLineSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this._trackbrLineSize.LargeChange = 1;
            this._trackbrLineSize.Location = new System.Drawing.Point(15, 229);
            this._trackbrLineSize.Maximum = 41;
            this._trackbrLineSize.Minimum = 1;
            this._trackbrLineSize.Name = "_trackbrLineSize";
            this._trackbrLineSize.Size = new System.Drawing.Size(198, 45);
            this._trackbrLineSize.TabIndex = 1;
            this._trackbrLineSize.Value = 5;
            this._trackbrLineSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this._trackbrLineSize_MouseUp);
            // 
            // _pnlPictureSize
            // 
            this._pnlPictureSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlPictureSize.BackColor = System.Drawing.Color.Crimson;
            this._pnlPictureSize.Controls.Add(this._btnPictureSizeOk);
            this._pnlPictureSize.Controls.Add(this.label6);
            this._pnlPictureSize.Controls.Add(this._txtHeight);
            this._pnlPictureSize.Controls.Add(this.label5);
            this._pnlPictureSize.Controls.Add(this._txtWidht);
            this._pnlPictureSize.Location = new System.Drawing.Point(628, 354);
            this._pnlPictureSize.Name = "_pnlPictureSize";
            this._pnlPictureSize.Size = new System.Drawing.Size(141, 95);
            this._pnlPictureSize.TabIndex = 10;
            this._pnlPictureSize.Visible = false;
            // 
            // _btnPictureSizeOk
            // 
            this._btnPictureSizeOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnPictureSizeOk.Location = new System.Drawing.Point(36, 63);
            this._btnPictureSizeOk.Name = "_btnPictureSizeOk";
            this._btnPictureSizeOk.Size = new System.Drawing.Size(75, 23);
            this._btnPictureSizeOk.TabIndex = 4;
            this._btnPictureSizeOk.Text = "Resim Seç";
            this._btnPictureSizeOk.UseVisualStyleBackColor = true;
            this._btnPictureSizeOk.Click += new System.EventHandler(this._btnPictureSizeOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Yükseklik:";
            // 
            // _txtHeight
            // 
            this._txtHeight.Location = new System.Drawing.Point(79, 37);
            this._txtHeight.Name = "_txtHeight";
            this._txtHeight.Size = new System.Drawing.Size(42, 20);
            this._txtHeight.TabIndex = 2;
            this._txtHeight.Text = "180";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Genişlik:";
            // 
            // _txtWidht
            // 
            this._txtWidht.Location = new System.Drawing.Point(79, 11);
            this._txtWidht.Name = "_txtWidht";
            this._txtWidht.Size = new System.Drawing.Size(42, 20);
            this._txtWidht.TabIndex = 0;
            this._txtWidht.Text = "200";
            // 
            // _pnlTextFormatSelect
            // 
            this._pnlTextFormatSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._pnlTextFormatSelect.BackColor = System.Drawing.Color.Crimson;
            this._pnlTextFormatSelect.Controls.Add(this.label4);
            this._pnlTextFormatSelect.Controls.Add(this.label3);
            this._pnlTextFormatSelect.Controls.Add(this._cmbFontStyle);
            this._pnlTextFormatSelect.Controls.Add(this._cmbFontSize);
            this._pnlTextFormatSelect.Controls.Add(this.label2);
            this._pnlTextFormatSelect.Controls.Add(this._cmbFontFormat);
            this._pnlTextFormatSelect.Location = new System.Drawing.Point(111, 339);
            this._pnlTextFormatSelect.Name = "_pnlTextFormatSelect";
            this._pnlTextFormatSelect.Size = new System.Drawing.Size(185, 110);
            this._pnlTextFormatSelect.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Boyut:";
            // 
            // _cmbFontStyle
            // 
            this._cmbFontStyle.FormattingEnabled = true;
            this._cmbFontStyle.Location = new System.Drawing.Point(56, 41);
            this._cmbFontStyle.Name = "_cmbFontStyle";
            this._cmbFontStyle.Size = new System.Drawing.Size(81, 21);
            this._cmbFontStyle.TabIndex = 2;
            this._cmbFontStyle.SelectedIndexChanged += new System.EventHandler(this._cmbFontStyle_SelectedIndexChanged);
            // 
            // _cmbFontSize
            // 
            this._cmbFontSize.FormattingEnabled = true;
            this._cmbFontSize.Location = new System.Drawing.Point(56, 68);
            this._cmbFontSize.Name = "_cmbFontSize";
            this._cmbFontSize.Size = new System.Drawing.Size(45, 21);
            this._cmbFontSize.TabIndex = 2;
            this._cmbFontSize.TextChanged += new System.EventHandler(this._cmbFontSize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font:";
            // 
            // _cmbFontFormat
            // 
            this._cmbFontFormat.FormattingEnabled = true;
            this._cmbFontFormat.Location = new System.Drawing.Point(56, 14);
            this._cmbFontFormat.Name = "_cmbFontFormat";
            this._cmbFontFormat.Size = new System.Drawing.Size(121, 21);
            this._cmbFontFormat.TabIndex = 0;
            this._cmbFontFormat.TextChanged += new System.EventHandler(this._cmbFontFormat_TextChanged);
            // 
            // _picCizimAlani
            // 
            this._picCizimAlani.BackColor = System.Drawing.Color.White;
            this._picCizimAlani.InitialImage = null;
            this._picCizimAlani.Location = new System.Drawing.Point(19, 12);
            this._picCizimAlani.Name = "_picCizimAlani";
            this._picCizimAlani.Size = new System.Drawing.Size(92, 59);
            this._picCizimAlani.TabIndex = 0;
            this._picCizimAlani.TabStop = false;
            this._picCizimAlani.MouseDown += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseDown);
            this._picCizimAlani.MouseMove += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseMove);
            this._picCizimAlani.MouseUp += new System.Windows.Forms.MouseEventHandler(this._picCizimAlani_MouseUp);
            // 
            // _imgListScreen
            // 
            this._imgListScreen.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this._imgListScreen.ImageSize = new System.Drawing.Size(16, 16);
            this._imgListScreen.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "Drawing Tool";
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            // 
            // DrawingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 493);
            this.Controls.Add(this._pnlCizimAlani);
            this.Controls.Add(this._pnlTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(722, 493);
            this.Name = "DrawingTool";
            this.Text = "Drawing Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DrawingTool_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawingTool_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DrawingTool_KeyUp);
            this._pnlTools.ResumeLayout(false);
            this._pnlCizimAlani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picAbout)).EndInit();
            this._pnlRenkEkran.ResumeLayout(false);
            this._pnlRenkEkran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picRenkPaleti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._trackbrLineSize)).EndInit();
            this._pnlPictureSize.ResumeLayout(false);
            this._pnlPictureSize.PerformLayout();
            this._pnlTextFormatSelect.ResumeLayout(false);
            this._pnlTextFormatSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picCizimAlani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlTools;
        private System.Windows.Forms.Panel _pnl_icon;
        private System.Windows.Forms.Panel _pnlCikis;
        private System.Windows.Forms.Panel _pnlCizimAlani;
        private System.Windows.Forms.PictureBox _picCizimAlani;
        private System.Windows.Forms.Panel _pnlLine;
        private System.Windows.Forms.Panel _pnlText;
        private System.Windows.Forms.Panel _pnlCursor;
        private System.Windows.Forms.Panel _pnlMasaustu;
        private System.Windows.Forms.Panel _pnlScreenShot;
        private System.Windows.Forms.Panel _pnlKalem;
        private System.Windows.Forms.Panel _pnlRenkBtn;
        private System.Windows.Forms.Panel _pnlRenkEkran;
        private System.Windows.Forms.Panel _pnlPaintingBucket;
        private System.Windows.Forms.TrackBar _trackbrLineSize;
        private System.Windows.Forms.PictureBox _picRenkPaleti;
        private System.Windows.Forms.TextBox _txtLineSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _pnlArrow;
        private System.Windows.Forms.Panel _pnlEllipse;
        private System.Windows.Forms.Panel _pnlRectagle;
        private System.Windows.Forms.Panel _pnlSettings;
        private System.Windows.Forms.Panel _pnlKaydet;
        private System.Windows.Forms.Panel _pnlPictureAdd;
        private System.Windows.Forms.ToolTip _toolTip_info;
        private System.Windows.Forms.Panel _pnlTextFormatSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cmbFontFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cmbFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cmbFontStyle;
        private System.Windows.Forms.ImageList _imgListScreen;
        private System.Windows.Forms.Panel _pnlNext;
        private System.Windows.Forms.Panel _pnlBack;
        private System.Windows.Forms.Panel _pnlPictureSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtWidht;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtHeight;
        private System.Windows.Forms.Button _btnPictureSizeOk;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.PictureBox _picAbout;
    }
}

