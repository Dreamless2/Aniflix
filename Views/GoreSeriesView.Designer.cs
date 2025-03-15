namespace Aniflix.Views
{
    partial class GoreSeriesView
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
            DiretorLabel = new Sunny.UI.UILabel();
            GeneroLabel = new Sunny.UI.UILabel();
            EstudioLabel = new Sunny.UI.UILabel();
            AnimeLabel = new Sunny.UI.UILabel();
            SinopseLabel = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // DiretorLabel
            // 
            DiretorLabel.AutoSize = true;
            DiretorLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DiretorLabel.ForeColor = Color.Black;
            DiretorLabel.Location = new Point(35, 582);
            DiretorLabel.Name = "DiretorLabel";
            DiretorLabel.Size = new Size(57, 20);
            DiretorLabel.TabIndex = 170;
            DiretorLabel.Text = "Diretor";
            // 
            // GeneroLabel
            // 
            GeneroLabel.AutoSize = true;
            GeneroLabel.Font = new Font("Microsoft Sans Serif", 12F);
            GeneroLabel.ForeColor = Color.Black;
            GeneroLabel.Location = new Point(35, 641);
            GeneroLabel.Name = "GeneroLabel";
            GeneroLabel.Size = new Size(63, 20);
            GeneroLabel.TabIndex = 169;
            GeneroLabel.Text = "Gênero";
            // 
            // EstudioLabel
            // 
            EstudioLabel.AutoSize = true;
            EstudioLabel.Font = new Font("Microsoft Sans Serif", 12F);
            EstudioLabel.ForeColor = Color.FromArgb(48, 48, 48);
            EstudioLabel.Location = new Point(35, 700);
            EstudioLabel.Name = "EstudioLabel";
            EstudioLabel.Size = new Size(63, 20);
            EstudioLabel.TabIndex = 168;
            EstudioLabel.Text = "Estúdio";
            // 
            // AnimeLabel
            // 
            AnimeLabel.AutoSize = true;
            AnimeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            AnimeLabel.ForeColor = Color.Black;
            AnimeLabel.Location = new Point(35, 464);
            AnimeLabel.Name = "AnimeLabel";
            AnimeLabel.Size = new Size(54, 20);
            AnimeLabel.TabIndex = 151;
            AnimeLabel.Text = "Anime";
            // 
            // SinopseLabel
            // 
            SinopseLabel.AutoSize = true;
            SinopseLabel.Font = new Font("Microsoft Sans Serif", 12F);
            SinopseLabel.ForeColor = Color.Black;
            SinopseLabel.Location = new Point(35, 91);
            SinopseLabel.Name = "SinopseLabel";
            SinopseLabel.Size = new Size(67, 20);
            SinopseLabel.TabIndex = 146;
            SinopseLabel.Text = "Sinopse";
            // 
            // GoreSeriesView
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1537, 911);
            Controls.Add(DiretorLabel);
            Controls.Add(GeneroLabel);
            Controls.Add(EstudioLabel);
            Controls.Add(AnimeLabel);
            Controls.Add(SinopseLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GoreSeriesView";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "Gore - Séries";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UILabel DiretorLabel;
        private Sunny.UI.UILabel GeneroLabel;
        private Sunny.UI.UILabel EstudioLabel;
        private Sunny.UI.UILabel AnimeLabel;
        private Sunny.UI.UILabel SinopseLabel;
    }
}