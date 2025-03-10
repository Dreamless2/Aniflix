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
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            FecharButton = new Sunny.UI.UIButton();
            LogoBox = new PictureBox();
            LinkSite = new LinkLabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 14.25F);
            uiSymbolLabel1.Location = new Point(117, 478);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(832, 33);
            uiSymbolLabel1.TabIndex = 1;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // FecharButton
            // 
            FecharButton.Font = new Font("Microsoft Sans Serif", 12F);
            FecharButton.Location = new Point(387, 730);
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
            LogoBox.Location = new Point(411, 547);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(220, 91);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 3;
            LogoBox.TabStop = false;
            LogoBox.Click += LogoBox_Click;
            LogoBox.MouseEnter += LogoBox_MouseEnter;
            // 
            // LinkSite
            // 
            LinkSite.AutoSize = true;
            LinkSite.Font = new Font("Microsoft Sans Serif", 14.25F);
            LinkSite.Location = new Point(504, 661);
            LinkSite.Name = "LinkSite";
            LinkSite.Size = new Size(63, 24);
            LinkSite.TabIndex = 4;
            LinkSite.TabStop = true;
            LinkSite.Text = "TMDB";
            LinkSite.LinkClicked += LinkSite_LinkClicked;
            // 
            // uiLabel1
            // 
            uiLabel1.AutoSize = true;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 14.25F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(143, 661);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(364, 24);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "Para acessar o site do TMDB, clique aqui: ";
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSmoothLabel1.Location = new Point(206, 128);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.Size = new Size(605, 198);
            uiSmoothLabel1.TabIndex = 6;
            uiSmoothLabel1.Text = "Aniflix";
            uiSmoothLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1060, 828);
            Controls.Add(uiSmoothLabel1);
            Controls.Add(uiLabel1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton FecharButton;
        private PictureBox LogoBox;
        private LinkLabel LinkSite;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
    }
}