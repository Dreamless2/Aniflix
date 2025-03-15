namespace Aniflix.Views
{
    partial class SobreView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            LicenseBox = new PictureBox();
            LinkLicenseSite = new LinkLabel();
            LinkTMDB = new LinkLabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLine2 = new Sunny.UI.UILine();
            uiLine1 = new Sunny.UI.UILine();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            DEEPLVersion = new Sunny.UI.UISymbolLabel();
            LogoBox = new PictureBox();
            SunnyBox = new PictureBox();
            SunnyVersion = new Sunny.UI.UISymbolLabel();
            TMDBLibVersion = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            FecharButton = new Sunny.UI.UIButton();
            LinkTMDBLib = new LinkLabel();
            LinkSunnyUI = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SunnyBox).BeginInit();
            SuspendLayout();
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.BackColor = Color.Transparent;
            uiSymbolLabel2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel2.Location = new Point(8, 205);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(185, 28);
            uiSymbolLabel2.Symbol = 560403;
            uiSymbolLabel2.TabIndex = 17;
            uiSymbolLabel2.Text = "Licensed under GPLv3";
            // 
            // LicenseBox
            // 
            LicenseBox.Image = Properties.Resources.gpl_logo;
            LicenseBox.ImageLocation = "";
            LicenseBox.Location = new Point(539, 116);
            LicenseBox.Name = "LicenseBox";
            LicenseBox.Size = new Size(259, 83);
            LicenseBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LicenseBox.TabIndex = 15;
            LicenseBox.TabStop = false;
            LicenseBox.Click += LicenseBox_Click;
            LicenseBox.MouseEnter += LicenseBox_MouseEnter;
            // 
            // LinkLicenseSite
            // 
            LinkLicenseSite.AutoSize = true;
            LinkLicenseSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLicenseSite.Location = new Point(675, 476);
            LinkLicenseSite.Name = "LinkLicenseSite";
            LinkLicenseSite.Size = new Size(156, 16);
            LinkLicenseSite.TabIndex = 16;
            LinkLicenseSite.TabStop = true;
            LinkLicenseSite.Text = "GNU GPLv3 Home Page";
            LinkLicenseSite.LinkClicked += LinkLicenseSite_LinkClicked;
            // 
            // LinkTMDB
            // 
            LinkTMDB.AutoSize = true;
            LinkTMDB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTMDB.Location = new Point(22, 476);
            LinkTMDB.Name = "LinkTMDB";
            LinkTMDB.Size = new Size(122, 16);
            LinkTMDB.TabIndex = 14;
            LinkTMDB.TabStop = true;
            LinkTMDB.Text = "TMDB Home Page";
            LinkTMDB.LinkClicked += LinkTMDB_LinkClicked;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(9, 239);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(524, 28);
            uiSymbolLabel1.Symbol = 560403;
            uiSymbolLabel1.TabIndex = 12;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aniflix;
            pictureBox1.Location = new Point(22, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.AutoSize = true;
            uiLabel1.Font = new Font("Merriweather Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(202, 62);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(107, 44);
            uiLabel1.TabIndex = 20;
            uiLabel1.Text = "Aniflix";
            // 
            // uiLine2
            // 
            uiLine2.BackColor = Color.Transparent;
            uiLine2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine2.LineColor = Color.FromArgb(13, 37, 63);
            uiLine2.LineDashStyle = Sunny.UI.UILineDashStyle.Custom;
            uiLine2.LineSize = 5;
            uiLine2.Location = new Point(202, 98);
            uiLine2.MinimumSize = new Size(1, 1);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(631, 29);
            uiLine2.TabIndex = 19;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.LineColor = Color.FromArgb(13, 37, 63);
            uiLine1.LineDashStyle = Sunny.UI.UILineDashStyle.Custom;
            uiLine1.LineSize = 5;
            uiLine1.Location = new Point(202, 41);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(631, 29);
            uiLine1.TabIndex = 18;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(DEEPLVersion);
            uiGroupBox1.Controls.Add(LogoBox);
            uiGroupBox1.Controls.Add(SunnyBox);
            uiGroupBox1.Controls.Add(SunnyVersion);
            uiGroupBox1.Controls.Add(TMDBLibVersion);
            uiGroupBox1.Controls.Add(uiSymbolLabel4);
            uiGroupBox1.Controls.Add(uiSymbolLabel3);
            uiGroupBox1.Controls.Add(uiSymbolLabel1);
            uiGroupBox1.Controls.Add(uiSymbolLabel2);
            uiGroupBox1.Controls.Add(LicenseBox);
            uiGroupBox1.FillColor = Color.FromArgb(244, 242, 251);
            uiGroupBox1.FillColor2 = Color.FromArgb(244, 242, 251);
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(22, 153);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.FromArgb(102, 58, 183);
            uiGroupBox1.Size = new Size(811, 301);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 22;
            uiGroupBox1.Text = "Aniflix 1.0.0, 64 bits - 2025/03/10 22:41:30";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // DEEPLVersion
            // 
            DEEPLVersion.BackColor = Color.Transparent;
            DEEPLVersion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DEEPLVersion.Location = new Point(9, 171);
            DEEPLVersion.MinimumSize = new Size(1, 1);
            DEEPLVersion.Name = "DEEPLVersion";
            DEEPLVersion.Size = new Size(147, 28);
            DEEPLVersion.Symbol = 560403;
            DEEPLVersion.TabIndex = 24;
            DEEPLVersion.Text = "DeepL.NET";
            DEEPLVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.tmdb_logo;
            LogoBox.ImageLocation = "";
            LogoBox.Location = new Point(539, 27);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(259, 83);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 23;
            LogoBox.TabStop = false;
            LogoBox.Click += LogoBox_Click;
            LogoBox.MouseEnter += LogoBox_MouseEnter;
            // 
            // SunnyBox
            // 
            SunnyBox.Image = Properties.Resources.sunnyui;
            SunnyBox.ImageLocation = "";
            SunnyBox.Location = new Point(539, 205);
            SunnyBox.Name = "SunnyBox";
            SunnyBox.Size = new Size(259, 83);
            SunnyBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SunnyBox.TabIndex = 22;
            SunnyBox.TabStop = false;
            SunnyBox.Click += SunnyBox_Click;
            SunnyBox.MouseEnter += SunnyBox_MouseEnter;
            // 
            // SunnyVersion
            // 
            SunnyVersion.BackColor = Color.Transparent;
            SunnyVersion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SunnyVersion.Location = new Point(9, 137);
            SunnyVersion.MinimumSize = new Size(1, 1);
            SunnyVersion.Name = "SunnyVersion";
            SunnyVersion.Size = new Size(127, 28);
            SunnyVersion.Symbol = 560403;
            SunnyVersion.TabIndex = 21;
            SunnyVersion.Text = "SunnyUI";
            SunnyVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TMDBLibVersion
            // 
            TMDBLibVersion.BackColor = Color.Transparent;
            TMDBLibVersion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TMDBLibVersion.Location = new Point(9, 103);
            TMDBLibVersion.MinimumSize = new Size(1, 1);
            TMDBLibVersion.Name = "TMDBLibVersion";
            TMDBLibVersion.Size = new Size(134, 28);
            TMDBLibVersion.Symbol = 560403;
            TMDBLibVersion.TabIndex = 20;
            TMDBLibVersion.Text = "TMDBLib";
            TMDBLibVersion.TextAlign = ContentAlignment.MiddleLeft;
            TMDBLibVersion.Click += TMDBLibVersion_Click;
            // 
            // uiSymbolLabel4
            // 
            uiSymbolLabel4.BackColor = Color.Transparent;
            uiSymbolLabel4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel4.Location = new Point(8, 69);
            uiSymbolLabel4.MinimumSize = new Size(1, 1);
            uiSymbolLabel4.Name = "uiSymbolLabel4";
            uiSymbolLabel4.Size = new Size(90, 28);
            uiSymbolLabel4.Symbol = 560403;
            uiSymbolLabel4.TabIndex = 19;
            uiSymbolLabel4.Text = "NET 8.0";
            // 
            // uiSymbolLabel3
            // 
            uiSymbolLabel3.BackColor = Color.Transparent;
            uiSymbolLabel3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel3.Location = new Point(8, 35);
            uiSymbolLabel3.MinimumSize = new Size(1, 1);
            uiSymbolLabel3.Name = "uiSymbolLabel3";
            uiSymbolLabel3.Size = new Size(305, 28);
            uiSymbolLabel3.Symbol = 560403;
            uiSymbolLabel3.TabIndex = 18;
            uiSymbolLabel3.Text = "Aniflix 1.0.0, 64 bits - 2025/03/10 22:41:30";
            // 
            // FecharButton
            // 
            FecharButton.Font = new Font("Microsoft Sans Serif", 12F);
            FecharButton.Location = new Point(699, 519);
            FecharButton.MinimumSize = new Size(1, 1);
            FecharButton.Name = "FecharButton";
            FecharButton.Size = new Size(132, 45);
            FecharButton.TabIndex = 23;
            FecharButton.Text = "Fechar";
            FecharButton.TipsFont = new Font("Microsoft Sans Serif", 9F);
            FecharButton.Click += FecharButton_Click;
            // 
            // LinkTMDBLib
            // 
            LinkTMDBLib.AutoSize = true;
            LinkTMDBLib.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTMDBLib.Location = new Point(217, 476);
            LinkTMDBLib.Name = "LinkTMDBLib";
            LinkTMDBLib.Size = new Size(140, 16);
            LinkTMDBLib.TabIndex = 24;
            LinkTMDBLib.TabStop = true;
            LinkTMDBLib.Text = "TMDBLib Home Page";
            LinkTMDBLib.LinkClicked += LinkTMDBLib_LinkClicked;
            // 
            // LinkSunnyUI
            // 
            LinkSunnyUI.AutoSize = true;
            LinkSunnyUI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSunnyUI.Location = new Point(446, 476);
            LinkSunnyUI.Name = "LinkSunnyUI";
            LinkSunnyUI.Size = new Size(133, 16);
            LinkSunnyUI.TabIndex = 25;
            LinkSunnyUI.TabStop = true;
            LinkSunnyUI.Text = "SunnyUI Home Page";
            LinkSunnyUI.LinkClicked += LinkSunnyUI_LinkClicked;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 242, 251);
            ClientSize = new Size(852, 588);
            ControlBoxFillHoverColor = Color.FromArgb(133, 97, 198);
            Controls.Add(LinkSunnyUI);
            Controls.Add(LinkTMDBLib);
            Controls.Add(FecharButton);
            Controls.Add(uiLine2);
            Controls.Add(uiGroupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(uiLine1);
            Controls.Add(LinkLicenseSite);
            Controls.Add(LinkTMDB);
            Controls.Add(uiLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            RectColor = Color.FromArgb(102, 58, 183);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Sobre";
            TitleColor = Color.FromArgb(102, 58, 183);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)LicenseBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SunnyBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private PictureBox LicenseBox;
        private LinkLabel LinkLicenseSite;
        private LinkLabel LinkTMDB;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel TMDBLibVersion;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIButton FecharButton;
        private Sunny.UI.UISymbolLabel SunnyVersion;
        private PictureBox SunnyBox;
        private LinkLabel LinkTMDBLib;
        private LinkLabel LinkSunnyUI;
        private PictureBox LogoBox;
        private Sunny.UI.UISymbolLabel DEEPLVersion;
    }
}