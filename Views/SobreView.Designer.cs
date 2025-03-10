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
            LogoBox = new PictureBox();
            LinkSite = new LinkLabel();
            LicenseBox = new PictureBox();
            LicenseSite = new LinkLabel();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            svgPictureBox1 = new SharpVectors.Renderers.Forms.SvgPictureBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiLine1 = new Sunny.UI.UILine();
            uiLine2 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LicenseBox).BeginInit();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).BeginInit();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel1.Location = new Point(31, 137);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(524, 28);
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
            uiSymbolLabel2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolLabel2.Location = new Point(779, 137);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(281, 28);
            uiSymbolLabel2.TabIndex = 9;
            uiSymbolLabel2.Text = "Licenciado sob os termos da GPLv3.";
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.FromArgb(237, 239, 240);
            uiPanel1.Controls.Add(uiSymbolLabel2);
            uiPanel1.Controls.Add(LicenseBox);
            uiPanel1.Controls.Add(LicenseSite);
            uiPanel1.Controls.Add(LogoBox);
            uiPanel1.Controls.Add(LinkSite);
            uiPanel1.Controls.Add(uiSymbolLabel1);
            uiPanel1.Dock = DockStyle.Bottom;
            uiPanel1.FillColor = Color.FromArgb(237, 239, 240);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 264);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel1.Size = new Size(1077, 189);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // svgPictureBox1
            // 
            svgPictureBox1.Dock = DockStyle.Left;
            svgPictureBox1.Location = new Point(0, 0);
            svgPictureBox1.Name = "svgPictureBox1";
            svgPictureBox1.Size = new Size(216, 230);
            svgPictureBox1.TabIndex = 2;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiLine2);
            uiPanel2.Controls.Add(uiLine1);
            uiPanel2.Controls.Add(svgPictureBox1);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 35);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel2.Size = new Size(1077, 230);
            uiPanel2.TabIndex = 11;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
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
            uiLine1.Size = new Size(814, 29);
            uiLine1.TabIndex = 3;
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
            uiLine2.Size = new Size(814, 29);
            uiLine2.TabIndex = 4;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1077, 453);
            Controls.Add(uiPanel2);
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
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).EndInit();
            uiPanel2.ResumeLayout(false);
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
        private SharpVectors.Renderers.Forms.SvgPictureBox svgPictureBox1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
    }
}