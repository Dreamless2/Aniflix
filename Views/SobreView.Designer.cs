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
            uiButton1 = new Sunny.UI.UIButton();
            materialPictureBox1 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            ((System.ComponentModel.ISupportInitialize)materialPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(94, 666);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(832, 33);
            uiSymbolLabel1.TabIndex = 1;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(367, 730);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(310, 72);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "Fechar";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // materialPictureBox1
            // 
            materialPictureBox1.BackColor = Color.FromArgb(243, 249, 255);
            materialPictureBox1.ForeColor = Color.FromArgb(48, 48, 48);
            materialPictureBox1.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            materialPictureBox1.IconColor = Color.FromArgb(48, 48, 48);
            materialPictureBox1.IconSize = 224;
            materialPictureBox1.Location = new Point(291, 361);
            materialPictureBox1.Name = "materialPictureBox1";
            materialPictureBox1.Size = new Size(359, 224);
            materialPictureBox1.TabIndex = 3;
            materialPictureBox1.TabStop = false;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1060, 828);
            Controls.Add(materialPictureBox1);
            Controls.Add(uiButton1);
            Controls.Add(uiSymbolLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "SobreView";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)materialPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton uiButton1;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox1;
    }
}