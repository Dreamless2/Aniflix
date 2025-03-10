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
            uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(114, 666);
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
            LogoBox.Location = new Point(400, 441);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(300, 189);
            LogoBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LogoBox.TabIndex = 3;
            LogoBox.TabStop = false;
            LogoBox.Click += LogoBox_Click;
            // 
            // uiLinkLabel1
            // 
            uiLinkLabel1.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            uiLinkLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLinkLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            uiLinkLabel1.Location = new Point(226, 255);
            uiLinkLabel1.Name = "uiLinkLabel1";
            uiLinkLabel1.Size = new Size(100, 23);
            uiLinkLabel1.TabIndex = 4;
            uiLinkLabel1.TabStop = true;
            uiLinkLabel1.Text = "uiLinkLabel1";
            uiLinkLabel1.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1060, 828);
            Controls.Add(uiLinkLabel1);
            Controls.Add(LogoBox);
            Controls.Add(FecharButton);
            Controls.Add(uiSymbolLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "SobreView";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIButton FecharButton;
        private PictureBox LogoBox;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
    }
}