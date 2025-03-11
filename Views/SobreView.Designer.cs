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
            uiPanel2 = new Sunny.UI.UIPanel();
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLine2 = new Sunny.UI.UILine();
            uiLine1 = new Sunny.UI.UILine();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            LicenseBox = new PictureBox();
            LicenseSite = new LinkLabel();
            LogoBox = new PictureBox();
            LinkSite = new LinkLabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(pictureBox1);
            uiPanel2.Controls.Add(uiLabel1);
            uiPanel2.Controls.Add(uiLine2);
            uiPanel2.Controls.Add(uiLine1);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 35);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel2.Size = new Size(852, 230);
            uiPanel2.TabIndex = 11;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.aniflix;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.AutoSize = true;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(246, 34);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(203, 73);
            uiLabel1.TabIndex = 5;
            uiLabel1.Text = "Aniflix";
            // 
            // uiLine2
            // 
            uiLine2.BackColor = Color.Transparent;
            uiLine2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine2.LineDashStyle = Sunny.UI.UILineDashStyle.Custom;
            uiLine2.LineSize = 5;
            uiLine2.Location = new Point(246, 103);
            uiLine2.MinimumSize = new Size(1, 1);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(596, 29);
            uiLine2.TabIndex = 4;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.LineDashStyle = Sunny.UI.UILineDashStyle.Custom;
            uiLine1.LineSize = 5;
            uiLine1.Location = new Point(246, 13);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(596, 29);
            uiLine1.TabIndex = 3;
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.BackColor = Color.Transparent;
            uiSymbolLabel2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel2.Location = new Point(548, 378);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(281, 28);
            uiSymbolLabel2.TabIndex = 17;
            uiSymbolLabel2.Text = "Licenciado sob os termos da GPLv3.";
            // 
            // LicenseBox
            // 
            LicenseBox.ImageLocation = "https://www.gnu.org/graphics/gplv3-with-text-136x68.png";
            LicenseBox.Location = new Point(671, 276);
            LicenseBox.Name = "LicenseBox";
            LicenseBox.Size = new Size(158, 83);
            LicenseBox.SizeMode = PictureBoxSizeMode.CenterImage;
            LicenseBox.TabIndex = 15;
            LicenseBox.TabStop = false;
            // 
            // LicenseSite
            // 
            LicenseSite.AutoSize = true;
            LicenseSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LicenseSite.Location = new Point(673, 349);
            LicenseSite.Name = "LicenseSite";
            LicenseSite.Size = new Size(156, 16);
            LicenseSite.TabIndex = 16;
            LicenseSite.TabStop = true;
            LicenseSite.Text = "GNU GPLv3 Home Page";
            // 
            // LogoBox
            // 
            LogoBox.Image = Properties.Resources.tmdb_logo;
            LogoBox.Location = new Point(18, 276);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(155, 83);
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.TabIndex = 13;
            LogoBox.TabStop = false;
            // 
            // LinkSite
            // 
            LinkSite.AutoSize = true;
            LinkSite.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSite.Location = new Point(18, 349);
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
            uiSymbolLabel1.Location = new Point(18, 378);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(524, 28);
            uiSymbolLabel1.TabIndex = 12;
            uiSymbolLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(852, 746);
            Controls.Add(uiSymbolLabel2);
            Controls.Add(LicenseBox);
            Controls.Add(LicenseSite);
            Controls.Add(LogoBox);
            Controls.Add(LinkSite);
            Controls.Add(uiSymbolLabel1);
            Controls.Add(uiPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "Sobre";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += SobreView_Load;
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILabel uiLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private PictureBox LicenseBox;
        private LinkLabel LicenseSite;
        private PictureBox LogoBox;
        private LinkLabel LinkSite;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}