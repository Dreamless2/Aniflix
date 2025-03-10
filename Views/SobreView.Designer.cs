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
            FecharButton = new Sunny.UI.UIButton();
            LogoBox = new PictureBox();
            LinkSite = new LinkLabel();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            LicenseBox = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(291, 328);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(472, 28);
            uiSymbolLabel1.TabIndex = 1;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // FecharButton
            // 
            FecharButton.Font = new Font("Microsoft Sans Serif", 12F);
            FecharButton.Location = new Point(245, 537);
            FecharButton.MinimumSize = new Size(1, 1);
            FecharButton.Name = "FecharButton";
            FecharButton.Size = new Size(310, 72);
            FecharButton.TabIndex = 2;
            FecharButton.Text = "Fechar";
            FecharButton.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.tmdb_logo;
            LogoBox.Location = new Point(41, 217);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(169, 83);
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
            LinkSite.Location = new Point(41, 340);
            LinkSite.Name = "LinkSite";
            LinkSite.Size = new Size(122, 16);
            LinkSite.TabIndex = 4;
            LinkSite.TabStop = true;
            LinkSite.Text = "TMDB Home Page";
            LinkSite.LinkClicked += LinkSite_LinkClicked;
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.AutoSize = true;
            uiSmoothLabel1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSmoothLabel1.Location = new Point(79, 85);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.Size = new Size(203, 73);
            uiSmoothLabel1.TabIndex = 6;
            uiSmoothLabel1.Text = "Aniflix";
            uiSmoothLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LicenseBox
            // 
            LicenseBox.ImageLocation = "https://www.gnu.org/graphics/gplv3-with-text-136x68.png";
            LicenseBox.Location = new Point(881, 328);
            LicenseBox.Name = "LicenseBox";
            LicenseBox.Size = new Size(158, 72);
            LicenseBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LicenseBox.TabIndex = 7;
            LicenseBox.TabStop = false;
            LicenseBox.Click += LicenseBox_Click;
            LicenseBox.MouseEnter += LicenseBox_MouseEnter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(490, 436);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 16);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TMDB Home Page";
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1102, 888);
            Controls.Add(linkLabel1);
            Controls.Add(LicenseBox);
            Controls.Add(uiSmoothLabel1);
            Controls.Add(LinkSite);
            Controls.Add(LogoBox);
            Controls.Add(FecharButton);
            Controls.Add(uiSymbolLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "Sobre";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton FecharButton;
        private PictureBox LogoBox;
        private LinkLabel LinkSite;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private PictureBox LicenseBox;
        private LinkLabel linkLabel1;
    }
}