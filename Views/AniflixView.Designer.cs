namespace Aniflix.Views
{
    partial class AniflixView
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
            MenuPanel = new Sunny.UI.UIPanel();
            SairButton = new FontAwesome.Sharp.Material.MaterialButton();
            TrashflixButton = new FontAwesome.Sharp.Material.MaterialButton();
            BreakOutSeriesButton = new FontAwesome.Sharp.Material.MaterialButton();
            BreakOutFilmesButton = new FontAwesome.Sharp.Material.MaterialButton();
            GoreSeriesButton = new FontAwesome.Sharp.Material.MaterialButton();
            GoreFilmesButton = new FontAwesome.Sharp.Material.MaterialButton();
            AnimesFilmesButton = new FontAwesome.Sharp.Material.MaterialButton();
            AnimesButton = new FontAwesome.Sharp.Material.MaterialButton();
            SeriesButton = new FontAwesome.Sharp.Material.MaterialButton();
            FilmesButton = new FontAwesome.Sharp.Material.MaterialButton();
            LogoPanel = new Sunny.UI.UIPanel();
            TitleBarPanel = new Sunny.UI.UITitlePanel();
            TitleChildFormLabel = new Sunny.UI.UILabel();
            CurrentChildFormBox = new FontAwesome.Sharp.Material.MaterialPictureBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            DesktopPanel = new Sunny.UI.UIPanel();
            MenuPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentChildFormBox).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Controls.Add(SairButton);
            MenuPanel.Controls.Add(TrashflixButton);
            MenuPanel.Controls.Add(BreakOutSeriesButton);
            MenuPanel.Controls.Add(BreakOutFilmesButton);
            MenuPanel.Controls.Add(GoreSeriesButton);
            MenuPanel.Controls.Add(GoreFilmesButton);
            MenuPanel.Controls.Add(AnimesFilmesButton);
            MenuPanel.Controls.Add(AnimesButton);
            MenuPanel.Controls.Add(SeriesButton);
            MenuPanel.Controls.Add(FilmesButton);
            MenuPanel.Controls.Add(LogoPanel);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.FillColor = Color.FromArgb(31, 30, 68);
            MenuPanel.FillColor2 = Color.FromArgb(31, 30, 68);
            MenuPanel.FillDisableColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Font = new Font("Microsoft Sans Serif", 12F);
            MenuPanel.Location = new Point(0, 35);
            MenuPanel.Margin = new Padding(4, 5, 4, 5);
            MenuPanel.MinimumSize = new Size(1, 1);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop;
            MenuPanel.RectSides = ToolStripStatusLabelBorderSides.None;
            MenuPanel.Size = new Size(258, 998);
            MenuPanel.TabIndex = 0;
            MenuPanel.Text = null;
            MenuPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // SairButton
            // 
            SairButton.Dock = DockStyle.Top;
            SairButton.FlatAppearance.BorderSize = 0;
            SairButton.FlatStyle = FlatStyle.Flat;
            SairButton.Font = new Font("Microsoft Sans Serif", 12F);
            SairButton.ForeColor = Color.White;
            SairButton.IconChar = FontAwesome.Sharp.MaterialIcons.ExitToApp;
            SairButton.IconColor = Color.White;
            SairButton.ImageAlign = ContentAlignment.MiddleLeft;
            SairButton.Location = new Point(0, 630);
            SairButton.Name = "SairButton";
            SairButton.Padding = new Padding(10, 0, 20, 0);
            SairButton.Size = new Size(258, 60);
            SairButton.TabIndex = 11;
            SairButton.Text = "Sair";
            SairButton.TextAlign = ContentAlignment.MiddleLeft;
            SairButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SairButton.UseVisualStyleBackColor = true;
            SairButton.Click += SairButton_Click;
            // 
            // TrashflixButton
            // 
            TrashflixButton.Dock = DockStyle.Top;
            TrashflixButton.FlatAppearance.BorderSize = 0;
            TrashflixButton.FlatStyle = FlatStyle.Flat;
            TrashflixButton.Font = new Font("Microsoft Sans Serif", 12F);
            TrashflixButton.ForeColor = Color.White;
            TrashflixButton.IconChar = FontAwesome.Sharp.MaterialIcons.DeleteSweep;
            TrashflixButton.IconColor = Color.White;
            TrashflixButton.ImageAlign = ContentAlignment.MiddleLeft;
            TrashflixButton.Location = new Point(0, 570);
            TrashflixButton.Name = "TrashflixButton";
            TrashflixButton.Padding = new Padding(10, 0, 20, 0);
            TrashflixButton.Size = new Size(258, 60);
            TrashflixButton.TabIndex = 10;
            TrashflixButton.Text = "Trashflix";
            TrashflixButton.TextAlign = ContentAlignment.MiddleLeft;
            TrashflixButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            TrashflixButton.UseVisualStyleBackColor = true;
            // 
            // BreakOutSeriesButton
            // 
            BreakOutSeriesButton.Dock = DockStyle.Top;
            BreakOutSeriesButton.FlatAppearance.BorderSize = 0;
            BreakOutSeriesButton.FlatStyle = FlatStyle.Flat;
            BreakOutSeriesButton.Font = new Font("Microsoft Sans Serif", 12F);
            BreakOutSeriesButton.ForeColor = Color.White;
            BreakOutSeriesButton.IconChar = FontAwesome.Sharp.MaterialIcons.HumanNonBinary;
            BreakOutSeriesButton.IconColor = Color.White;
            BreakOutSeriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            BreakOutSeriesButton.Location = new Point(0, 510);
            BreakOutSeriesButton.Name = "BreakOutSeriesButton";
            BreakOutSeriesButton.Padding = new Padding(10, 0, 20, 0);
            BreakOutSeriesButton.Size = new Size(258, 60);
            BreakOutSeriesButton.TabIndex = 9;
            BreakOutSeriesButton.Text = "BreakOut - Séries";
            BreakOutSeriesButton.TextAlign = ContentAlignment.MiddleLeft;
            BreakOutSeriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BreakOutSeriesButton.UseVisualStyleBackColor = true;
            BreakOutSeriesButton.Click += BreakOutSeriesButton_Click;
            // 
            // BreakOutFilmesButton
            // 
            BreakOutFilmesButton.Dock = DockStyle.Top;
            BreakOutFilmesButton.FlatAppearance.BorderSize = 0;
            BreakOutFilmesButton.FlatStyle = FlatStyle.Flat;
            BreakOutFilmesButton.Font = new Font("Microsoft Sans Serif", 12F);
            BreakOutFilmesButton.ForeColor = Color.White;
            BreakOutFilmesButton.IconChar = FontAwesome.Sharp.MaterialIcons.Babel;
            BreakOutFilmesButton.IconColor = Color.White;
            BreakOutFilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            BreakOutFilmesButton.Location = new Point(0, 450);
            BreakOutFilmesButton.Name = "BreakOutFilmesButton";
            BreakOutFilmesButton.Padding = new Padding(10, 0, 20, 0);
            BreakOutFilmesButton.Size = new Size(258, 60);
            BreakOutFilmesButton.TabIndex = 8;
            BreakOutFilmesButton.Text = "BreakOut - Filmes";
            BreakOutFilmesButton.TextAlign = ContentAlignment.MiddleLeft;
            BreakOutFilmesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BreakOutFilmesButton.UseVisualStyleBackColor = true;
            BreakOutFilmesButton.Click += BreakOutFilmesButton_Click;
            // 
            // GoreSeriesButton
            // 
            GoreSeriesButton.Dock = DockStyle.Top;
            GoreSeriesButton.FlatAppearance.BorderSize = 0;
            GoreSeriesButton.FlatStyle = FlatStyle.Flat;
            GoreSeriesButton.Font = new Font("Microsoft Sans Serif", 12F);
            GoreSeriesButton.ForeColor = Color.White;
            GoreSeriesButton.IconChar = FontAwesome.Sharp.MaterialIcons.MoviePlay;
            GoreSeriesButton.IconColor = Color.White;
            GoreSeriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            GoreSeriesButton.Location = new Point(0, 390);
            GoreSeriesButton.Name = "GoreSeriesButton";
            GoreSeriesButton.Padding = new Padding(10, 0, 20, 0);
            GoreSeriesButton.Size = new Size(258, 60);
            GoreSeriesButton.TabIndex = 7;
            GoreSeriesButton.Text = "Gore - Séries";
            GoreSeriesButton.TextAlign = ContentAlignment.MiddleLeft;
            GoreSeriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GoreSeriesButton.UseVisualStyleBackColor = true;
            GoreSeriesButton.Click += GoreSeriesButton_Click;
            // 
            // GoreFilmesButton
            // 
            GoreFilmesButton.Dock = DockStyle.Top;
            GoreFilmesButton.FlatAppearance.BorderSize = 0;
            GoreFilmesButton.FlatStyle = FlatStyle.Flat;
            GoreFilmesButton.Font = new Font("Microsoft Sans Serif", 12F);
            GoreFilmesButton.ForeColor = Color.White;
            GoreFilmesButton.IconChar = FontAwesome.Sharp.MaterialIcons.MoviePlus;
            GoreFilmesButton.IconColor = Color.White;
            GoreFilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            GoreFilmesButton.Location = new Point(0, 330);
            GoreFilmesButton.Name = "GoreFilmesButton";
            GoreFilmesButton.Padding = new Padding(10, 0, 20, 0);
            GoreFilmesButton.Size = new Size(258, 60);
            GoreFilmesButton.TabIndex = 6;
            GoreFilmesButton.Text = "Gore  - Filmes";
            GoreFilmesButton.TextAlign = ContentAlignment.MiddleLeft;
            GoreFilmesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GoreFilmesButton.UseVisualStyleBackColor = true;
            GoreFilmesButton.Click += GoreFilmesButton_Click;
            // 
            // AnimesFilmesButton
            // 
            AnimesFilmesButton.Dock = DockStyle.Top;
            AnimesFilmesButton.FlatAppearance.BorderSize = 0;
            AnimesFilmesButton.FlatStyle = FlatStyle.Flat;
            AnimesFilmesButton.Font = new Font("Microsoft Sans Serif", 12F);
            AnimesFilmesButton.ForeColor = Color.White;
            AnimesFilmesButton.IconChar = FontAwesome.Sharp.MaterialIcons.CameraImage;
            AnimesFilmesButton.IconColor = Color.White;
            AnimesFilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            AnimesFilmesButton.Location = new Point(0, 270);
            AnimesFilmesButton.Name = "AnimesFilmesButton";
            AnimesFilmesButton.Padding = new Padding(10, 0, 20, 0);
            AnimesFilmesButton.Size = new Size(258, 60);
            AnimesFilmesButton.TabIndex = 5;
            AnimesFilmesButton.Text = "Animes - Filmes";
            AnimesFilmesButton.TextAlign = ContentAlignment.MiddleLeft;
            AnimesFilmesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AnimesFilmesButton.UseVisualStyleBackColor = true;
            AnimesFilmesButton.Click += AnimesFilmesButton_Click;
            // 
            // AnimesButton
            // 
            AnimesButton.Dock = DockStyle.Top;
            AnimesButton.FlatAppearance.BorderSize = 0;
            AnimesButton.FlatStyle = FlatStyle.Flat;
            AnimesButton.Font = new Font("Microsoft Sans Serif", 12F);
            AnimesButton.ForeColor = Color.White;
            AnimesButton.IconChar = FontAwesome.Sharp.MaterialIcons.CameraIris;
            AnimesButton.IconColor = Color.White;
            AnimesButton.ImageAlign = ContentAlignment.MiddleLeft;
            AnimesButton.Location = new Point(0, 210);
            AnimesButton.Name = "AnimesButton";
            AnimesButton.Padding = new Padding(10, 0, 20, 0);
            AnimesButton.Size = new Size(258, 60);
            AnimesButton.TabIndex = 4;
            AnimesButton.Text = "Animes";
            AnimesButton.TextAlign = ContentAlignment.MiddleLeft;
            AnimesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AnimesButton.UseVisualStyleBackColor = true;
            AnimesButton.Click += AnimesButton_Click;
            // 
            // SeriesButton
            // 
            SeriesButton.Dock = DockStyle.Top;
            SeriesButton.FlatAppearance.BorderSize = 0;
            SeriesButton.FlatStyle = FlatStyle.Flat;
            SeriesButton.Font = new Font("Microsoft Sans Serif", 12F);
            SeriesButton.ForeColor = Color.White;
            SeriesButton.IconChar = FontAwesome.Sharp.MaterialIcons.Camcorder;
            SeriesButton.IconColor = Color.White;
            SeriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            SeriesButton.Location = new Point(0, 150);
            SeriesButton.Name = "SeriesButton";
            SeriesButton.Padding = new Padding(10, 0, 20, 0);
            SeriesButton.Size = new Size(258, 60);
            SeriesButton.TabIndex = 3;
            SeriesButton.Text = "Séries";
            SeriesButton.TextAlign = ContentAlignment.MiddleLeft;
            SeriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SeriesButton.UseVisualStyleBackColor = true;
            SeriesButton.Click += SeriesButton_Click;
            // 
            // FilmesButton
            // 
            FilmesButton.Dock = DockStyle.Top;
            FilmesButton.FlatAppearance.BorderSize = 0;
            FilmesButton.FlatStyle = FlatStyle.Flat;
            FilmesButton.Font = new Font("Microsoft Sans Serif", 12F);
            FilmesButton.ForeColor = Color.White;
            FilmesButton.IconChar = FontAwesome.Sharp.MaterialIcons.MovieRoll;
            FilmesButton.IconColor = Color.White;
            FilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            FilmesButton.Location = new Point(0, 90);
            FilmesButton.Name = "FilmesButton";
            FilmesButton.Padding = new Padding(10, 0, 20, 0);
            FilmesButton.Size = new Size(258, 60);
            FilmesButton.TabIndex = 2;
            FilmesButton.Text = "Filmes";
            FilmesButton.TextAlign = ContentAlignment.MiddleLeft;
            FilmesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FilmesButton.UseVisualStyleBackColor = true;
            FilmesButton.Click += FilmesButton_Click;
            // 
            // LogoPanel
            // 
            LogoPanel.Dock = DockStyle.Top;
            LogoPanel.FillColor = Color.FromArgb(31, 30, 68);
            LogoPanel.FillColor2 = Color.FromArgb(31, 30, 68);
            LogoPanel.FillDisableColor = Color.FromArgb(31, 30, 68);
            LogoPanel.Font = new Font("Microsoft Sans Serif", 12F);
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Margin = new Padding(4, 5, 4, 5);
            LogoPanel.MinimumSize = new Size(1, 1);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            LogoPanel.RectSides = ToolStripStatusLabelBorderSides.None;
            LogoPanel.Size = new Size(258, 90);
            LogoPanel.TabIndex = 1;
            LogoPanel.Text = null;
            LogoPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(26, 25, 62);
            TitleBarPanel.Controls.Add(TitleChildFormLabel);
            TitleBarPanel.Controls.Add(CurrentChildFormBox);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.FillColor = Color.FromArgb(26, 25, 62);
            TitleBarPanel.FillColor2 = Color.FromArgb(26, 25, 62);
            TitleBarPanel.Font = new Font("Microsoft Sans Serif", 12F);
            TitleBarPanel.Location = new Point(258, 35);
            TitleBarPanel.Margin = new Padding(4, 5, 4, 5);
            TitleBarPanel.MinimumSize = new Size(1, 1);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Padding = new Padding(1, 35, 1, 1);
            TitleBarPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            TitleBarPanel.RectColor = Color.FromArgb(0, 190, 172);
            TitleBarPanel.RectSides = ToolStripStatusLabelBorderSides.None;
            TitleBarPanel.ShowText = false;
            TitleBarPanel.Size = new Size(1563, 90);
            TitleBarPanel.Style = Sunny.UI.UIStyle.Custom;
            TitleBarPanel.TabIndex = 1;
            TitleBarPanel.Text = "Home";
            TitleBarPanel.TextAlignment = ContentAlignment.MiddleLeft;
            TitleBarPanel.TitleColor = Color.FromArgb(0, 190, 172);
            // 
            // TitleChildFormLabel
            // 
            TitleChildFormLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TitleChildFormLabel.ForeColor = Color.White;
            TitleChildFormLabel.Location = new Point(45, 50);
            TitleChildFormLabel.Name = "TitleChildFormLabel";
            TitleChildFormLabel.Size = new Size(167, 23);
            TitleChildFormLabel.TabIndex = 1;
            TitleChildFormLabel.Text = "Home";
            // 
            // CurrentChildFormBox
            // 
            CurrentChildFormBox.BackColor = Color.FromArgb(26, 25, 62);
            CurrentChildFormBox.ForeColor = Color.Gainsboro;
            CurrentChildFormBox.IconChar = FontAwesome.Sharp.MaterialIcons.Home;
            CurrentChildFormBox.IconColor = Color.Gainsboro;
            CurrentChildFormBox.Location = new Point(7, 46);
            CurrentChildFormBox.Name = "CurrentChildFormBox";
            CurrentChildFormBox.Size = new Size(32, 32);
            CurrentChildFormBox.TabIndex = 0;
            CurrentChildFormBox.TabStop = false;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(DesktopPanel);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(258, 125);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiPanel1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel1.Size = new Size(1563, 908);
            uiPanel1.TabIndex = 2;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // DesktopPanel
            // 
            DesktopPanel.Dock = DockStyle.Fill;
            DesktopPanel.Font = new Font("Microsoft Sans Serif", 12F);
            DesktopPanel.Location = new Point(0, 0);
            DesktopPanel.Margin = new Padding(4, 5, 4, 5);
            DesktopPanel.MinimumSize = new Size(1, 1);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            DesktopPanel.RectSides = ToolStripStatusLabelBorderSides.None;
            DesktopPanel.Size = new Size(1563, 908);
            DesktopPanel.TabIndex = 0;
            DesktopPanel.Text = null;
            DesktopPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // AniflixView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 248, 248);
            ClientSize = new Size(1821, 1033);
            ControlBoxFillHoverColor = Color.FromArgb(51, 171, 160);
            Controls.Add(uiPanel1);
            Controls.Add(TitleBarPanel);
            Controls.Add(MenuPanel);
            MaximizeBox = false;
            Name = "AniflixView";
            RectColor = Color.FromArgb(0, 150, 136);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "AniflixView";
            TitleColor = Color.FromArgb(0, 150, 136);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            MenuPanel.ResumeLayout(false);
            TitleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CurrentChildFormBox).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel MenuPanel;
        private Sunny.UI.UIPanel LogoPanel;
        private Sunny.UI.UITitlePanel TitleBarPanel;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel DesktopPanel;
        private Sunny.UI.UILabel TitleChildFormLabel;
        private FontAwesome.Sharp.Material.MaterialPictureBox CurrentChildFormBox;
        private FontAwesome.Sharp.Material.MaterialButton FilmesButton;
        private FontAwesome.Sharp.Material.MaterialButton SairButton;
        private FontAwesome.Sharp.Material.MaterialButton TrashflixButton;
        private FontAwesome.Sharp.Material.MaterialButton BreakOutSeriesButton;
        private FontAwesome.Sharp.Material.MaterialButton BreakOutFilmesButton;
        private FontAwesome.Sharp.Material.MaterialButton GoreSeriesButton;
        private FontAwesome.Sharp.Material.MaterialButton GoreFilmesButton;
        private FontAwesome.Sharp.Material.MaterialButton AnimesFilmesButton;
        private FontAwesome.Sharp.Material.MaterialButton AnimesButton;
        private FontAwesome.Sharp.Material.MaterialButton SeriesButton;
    }
}