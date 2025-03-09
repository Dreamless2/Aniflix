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
            svgPictureBox1 = new SharpVectors.Renderers.Forms.SvgPictureBox();
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // svgPictureBox1
            // 
            svgPictureBox1.Location = new Point(96, 296);
            svgPictureBox1.Name = "svgPictureBox1";
            svgPictureBox1.Size = new Size(200, 200);
            svgPictureBox1.TabIndex = 0;
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLedLabel1.Location = new Point(61, 193);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(100, 35);
            uiLedLabel1.TabIndex = 1;
            uiLedLabel1.Text = "uiLedLabel1";
            // 
            // SobreView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(817, 631);
            Controls.Add(uiLedLabel1);
            Controls.Add(svgPictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreView";
            Text = "SobreView";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)svgPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SharpVectors.Renderers.Forms.SvgPictureBox svgPictureBox1;
        private Sunny.UI.UILedLabel uiLedLabel1;
    }
}