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
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            LogoBox = new PictureBox();
            LinkSite = new LinkLabel();
            LicenseBox = new PictureBox();
            LicenseSite = new LinkLabel();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(31, 137);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(472, 28);
            uiSymbolLabel1.TabIndex = 1;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.tmdb_logo;
            LogoBox.Location = new Point(31, 12);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(155, 83);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 3;
            LogoBox.TabStop = false;
            LogoBox.Click += LogoBox_Click;
            LogoBox.MouseEnter += LogoBox_MouseEnter;
            // 
            // LinkSite
            // 
            LinkSite.AutoSize = true;
            LinkSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSite.Location = new Point(31, 108);
            LinkSite.Name = "LinkSite";
            LinkSite.Size = new Size(122, 16);
            LinkSite.TabIndex = 4;
            LinkSite.TabStop = true;
            LinkSite.Text = "TMDB Home Page";
            LinkSite.LinkClicked += LinkSite_LinkClicked;
            // 
            // LicenseBox
            // 
            LicenseBox.ImageLocation = "https://www.gnu.org/graphics/gplv3-with-text-136x68.png";
            LicenseBox.Location = new Point(902, 12);
            LicenseBox.Name = "LicenseBox";
            LicenseBox.Size = new Size(158, 83);
            LicenseBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LicenseBox.TabIndex = 7;
            LicenseBox.TabStop = false;
            LicenseBox.Click += LicenseBox_Click;
            LicenseBox.MouseEnter += LicenseBox_MouseEnter;
            // 
            // LicenseSite
            // 
            LicenseSite.AutoSize = true;
            LicenseSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LicenseSite.Location = new Point(904, 108);
            LicenseSite.Name = "LicenseSite";
            LicenseSite.Size = new Size(156, 16);
            LicenseSite.TabIndex = 8;
            LicenseSite.TabStop = true;
            LicenseSite.Text = "GNU GPLv3 Home Page";
            LicenseSite.LinkClicked += LicenseSite_LinkClicked;
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.BackColor = Color.Transparent;
            uiSymbolLabel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel2.Location = new Point(809, 137);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(251, 28);
            uiSymbolLabel2.TabIndex = 9;
            uiSymbolLabel2.Text = "Licenciado sob os termos da GPLv3.";
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.FromArgb(237, 239, 240);
            uiPanel1.Controls.Add(materialButton1);
            uiPanel1.Controls.Add(uiSymbolLabel2);
            uiPanel1.Controls.Add(LicenseBox);
            uiPanel1.Controls.Add(LicenseSite);
            uiPanel1.Controls.Add(LogoBox);
            uiPanel1.Controls.Add(LinkSite);
            uiPanel1.Controls.Add(uiSymbolLabel1);
            uiPanel1.Dock = DockStyle.Bottom;
            uiPanel1.FillColor = Color.FromArgb(237, 239, 240);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 261);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel1.Size = new Size(1102, 271);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            materialButton1.IconColor = Color.Black;
            materialButton1.Location = new Point(442, 183);
            materialButton1.Name = "materialButton1";
            materialButton1.Size = new Size(230, 67);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "materialButton1";
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1102, 532);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "Sobre";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private PictureBox LogoBox;
        private LinkLabel LinkSite;
        private PictureBox LicenseBox;
        private LinkLabel LicenseSite;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIPanel uiPanel1;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
    }
}