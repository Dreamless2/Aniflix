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
            svgPictureBox1 = new SharpVectors.Renderers.Forms.SvgPictureBox();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // svgPictureBox1
            // 
            svgPictureBox1.Location = new Point(409, 474);
            svgPictureBox1.Name = "svgPictureBox1";
            svgPictureBox1.Size = new Size(727, 317);
            svgPictureBox1.Source = null;
            svgPictureBox1.TabIndex = 0;
            svgPictureBox1.XmlSource = null;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolLabel1.Location = new Point(293, 388);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(559, 28);
            uiSymbolLabel1.TabIndex = 1;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1598, 828);
            Controls.Add(uiSymbolLabel1);
            Controls.Add(svgPictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "SobreView";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SharpVectors.Renderers.Forms.SvgPictureBox svgPictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}