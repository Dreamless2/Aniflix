﻿namespace Aniflix.Views
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
            uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            pictureBox2 = new PictureBox();
            svgPictureBox1 = new SharpVectors.Renderers.Forms.SvgPictureBox();
            LinkTMDBLib = new LinkLabel();
            LinkSunny = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).BeginInit();
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
            uiGroupBox1.Controls.Add(svgPictureBox1);
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
            // svgPictureBox1
            // 
            svgPictureBox1.Location = new Point(539, 26);
            svgPictureBox1.Name = "svgPictureBox1";
            svgPictureBox1.Size = new Size(259, 83);
            svgPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            svgPictureBox1.Source = "https://www.themoviedb.org/assets/2/v4/logos/v2/blue_square_1-5bdc75aaebeb75dc7ae79426ddd9be3b2be1e342510f8202baf6bffa71d7f5c4.svg";
            svgPictureBox1.TabIndex = 23;
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
            // 
            // LinkSunny
            // 
            LinkSunny.AutoSize = true;
            LinkSunny.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSunny.Location = new Point(446, 476);
            LinkSunny.Name = "LinkSunny";
            LinkSunny.Size = new Size(133, 16);
            LinkSunny.TabIndex = 25;
            LinkSunny.TabStop = true;
            LinkSunny.Text = "SunnyUI Home Page";
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(852, 605);
            Controls.Add(LinkSunny);
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
            Text = "Sobre";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)LicenseBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).EndInit();
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
        private SharpVectors.Renderers.Forms.SvgPictureBox svgPictureBox1;
        private LinkLabel LinkTMDBLib;
        private LinkLabel LinkSunny;
    }
}