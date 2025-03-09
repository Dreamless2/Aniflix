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
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            SuspendLayout();
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.ForeColor = Color.Black;
            uiLedLabel1.Location = new Point(36, 57);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(1555, 167);
            uiLedLabel1.TabIndex = 1;
            uiLedLabel1.Text = "This product uses the TMDB API but is not endorsed or certified by TMDB.";
            uiLedLabel1.TextAlign = ContentAlignment.TopLeft;
            uiLedLabel1.Click += uiLedLabel1_Click;
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1862, 828);
            Controls.Add(uiLedLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "SobreView";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILedLabel uiLedLabel1;
    }
}