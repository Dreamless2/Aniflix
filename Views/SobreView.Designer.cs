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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreView));
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            LicenseBox = new PictureBox();
            LicenseSite = new LinkLabel();
            LinkSite = new LinkLabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLine2 = new Sunny.UI.UILine();
            uiLine1 = new Sunny.UI.UILine();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            LogoBox = new SharpVectors.Renderers.Forms.SvgPictureBox();
            pictureBox2 = new PictureBox();
            uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            uiButton1 = new Sunny.UI.UIButton();
            LinkTMDBLib = new LinkLabel();
            LinkSunnyUI = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            LicenseBox.ImageLocation = "https://www.gnu.org/graphics/gplv3-with-text-136x68.png";
            LicenseBox.Location = new Point(539, 116);
            LicenseBox.Name = "LicenseBox";
            LicenseBox.Size = new Size(259, 83);
            LicenseBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LicenseBox.TabIndex = 15;
            LicenseBox.TabStop = false;
            // 
            // LicenseSite
            // 
            LicenseSite.AutoSize = true;
            LicenseSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LicenseSite.Location = new Point(675, 476);
            LicenseSite.Name = "LicenseSite";
            LicenseSite.Size = new Size(156, 16);
            LicenseSite.TabIndex = 16;
            LicenseSite.TabStop = true;
            LicenseSite.Text = "GNU GPLv3 Home Page";
            // 
            // LinkSite
            // 
            LinkSite.AutoSize = true;
            LinkSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSite.Location = new Point(22, 476);
            LinkSite.Name = "LinkSite";
            LinkSite.Size = new Size(122, 16);
            LinkSite.TabIndex = 14;
            LinkSite.TabStop = true;
            LinkSite.Text = "TMDB Home Page";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(8, 137);
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
            uiLabel1.Location = new Point(202, 68);
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
            uiLine2.Location = new Point(202, 104);
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
            uiLine1.Location = new Point(202, 49);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(631, 29);
            uiLine1.TabIndex = 18;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(LogoBox);
            uiGroupBox1.Controls.Add(pictureBox2);
            uiGroupBox1.Controls.Add(uiSymbolLabel6);
            uiGroupBox1.Controls.Add(uiSymbolLabel5);
            uiGroupBox1.Controls.Add(uiSymbolLabel4);
            uiGroupBox1.Controls.Add(uiSymbolLabel3);
            uiGroupBox1.Controls.Add(uiSymbolLabel1);
            uiGroupBox1.Controls.Add(uiSymbolLabel2);
            uiGroupBox1.Controls.Add(LicenseBox);
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(22, 153);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(811, 301);
            uiGroupBox1.TabIndex = 22;
            uiGroupBox1.Text = "Aniflix 1.0.0, 64 bits - 2025/03/10 22:41:30";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // LogoBox
            // 
            LogoBox.Location = new Point(539, 26);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(259, 83);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.Source = null;
            LogoBox.TabIndex = 23;
            LogoBox.XmlSource = null;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = resources.GetString("pictureBox2.ImageLocation");
            pictureBox2.Location = new Point(539, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // uiSymbolLabel6
            // 
            uiSymbolLabel6.BackColor = Color.Transparent;
            uiSymbolLabel6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel6.Location = new Point(8, 171);
            uiSymbolLabel6.MinimumSize = new Size(1, 1);
            uiSymbolLabel6.Name = "uiSymbolLabel6";
            uiSymbolLabel6.Size = new Size(127, 28);
            uiSymbolLabel6.Symbol = 560403;
            uiSymbolLabel6.TabIndex = 21;
            uiSymbolLabel6.Text = "SunnyUI 3.8.2";
            // 
            // uiSymbolLabel5
            // 
            uiSymbolLabel5.BackColor = Color.Transparent;
            uiSymbolLabel5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel5.Location = new Point(8, 103);
            uiSymbolLabel5.MinimumSize = new Size(1, 1);
            uiSymbolLabel5.Name = "uiSymbolLabel5";
            uiSymbolLabel5.Size = new Size(134, 28);
            uiSymbolLabel5.Symbol = 560403;
            uiSymbolLabel5.TabIndex = 20;
            uiSymbolLabel5.Text = "TMDBLib 2.2.0";
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
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(699, 537);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(132, 45);
            uiButton1.TabIndex = 23;
            uiButton1.Text = "uiButton1";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
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
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 242, 251);
            ClientSize = new Size(852, 605);
            ControlBoxFillHoverColor = Color.FromArgb(133, 97, 198);
            Controls.Add(LinkSunnyUI);
            Controls.Add(LinkTMDBLib);
            Controls.Add(uiButton1);
            Controls.Add(uiLine2);
            Controls.Add(uiGroupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(uiLine1);
            Controls.Add(LicenseSite);
            Controls.Add(LinkSite);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private PictureBox LicenseBox;
        private LinkLabel LicenseSite;
        private LinkLabel LinkSite;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private PictureBox pictureBox2;
        private SharpVectors.Renderers.Forms.SvgPictureBox LogoBox;
        private LinkLabel LinkTMDBLib;
        private LinkLabel LinkSunnyUI;
    }
}