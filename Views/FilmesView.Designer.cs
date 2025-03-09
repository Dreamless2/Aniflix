namespace Aniflix.Views
{
    partial class FilmesView
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
            CodigoFilmeLabel = new Sunny.UI.UILabel();
            CodigoText = new Sunny.UI.UITextBox();
            AudioBox = new Sunny.UI.UIComboBox();
            TituloText = new Sunny.UI.UITextBox();
            AudioLabel = new Sunny.UI.UILabel();
            TituloOriginalText = new Sunny.UI.UITextBox();
            TituloLabel = new Sunny.UI.UILabel();
            DataLancamentoText = new Sunny.UI.UITextBox();
            DataLancamentoLabel = new Sunny.UI.UILabel();
            TituloAlternativoText = new Sunny.UI.UITextBox();
            FranquiaLabel = new Sunny.UI.UILabel();
            Fra = new Sunny.UI.UILabel();
            uiTextBox7 = new Sunny.UI.UITextBox();
            TituloOriginalLabel = new Sunny.UI.UILabel();
            TagsText = new Sunny.UI.UITextBox();
            TituloAlternativoLabel = new Sunny.UI.UILabel();
            GeneroText = new Sunny.UI.UITextBox();
            FilmeLabel = new Sunny.UI.UILabel();
            FilmeText = new Sunny.UI.UITextBox();
            SinopseLabel = new Sunny.UI.UILabel();
            TagsLabel = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            uiLabel14 = new Sunny.UI.UILabel();
            uiLabel15 = new Sunny.UI.UILabel();
            DiretorText = new Sunny.UI.UITextBox();
            EstrelasText = new Sunny.UI.UITextBox();
            EstudioText = new Sunny.UI.UITextBox();
            FaseMCUText = new Sunny.UI.UITextBox();
            ResumoText = new Sunny.UI.UIRichTextBox();
            SinopseText = new Sunny.UI.UIRichTextBox();
            materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
            materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
            materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
            materialButton4 = new FontAwesome.Sharp.Material.MaterialButton();
            materialButton5 = new FontAwesome.Sharp.Material.MaterialButton();
            uiLabel16 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // CodigoFilmeLabel
            // 
            CodigoFilmeLabel.AutoSize = true;
            CodigoFilmeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            CodigoFilmeLabel.ForeColor = Color.Black;
            CodigoFilmeLabel.Location = new Point(44, 116);
            CodigoFilmeLabel.Name = "CodigoFilmeLabel";
            CodigoFilmeLabel.Size = new Size(123, 20);
            CodigoFilmeLabel.TabIndex = 34;
            CodigoFilmeLabel.Text = "Código do Filme";
            // 
            // CodigoText
            // 
            CodigoText.Font = new Font("Microsoft Sans Serif", 12F);
            CodigoText.Location = new Point(44, 141);
            CodigoText.Margin = new Padding(4, 5, 4, 5);
            CodigoText.MinimumSize = new Size(1, 16);
            CodigoText.Name = "CodigoText";
            CodigoText.Padding = new Padding(5);
            CodigoText.RectColor = Color.Black;
            CodigoText.ShowText = false;
            CodigoText.Size = new Size(161, 29);
            CodigoText.TabIndex = 35;
            CodigoText.TextAlignment = ContentAlignment.MiddleLeft;
            CodigoText.Watermark = "Código do Filme";
            // 
            // AudioBox
            // 
            AudioBox.DataSource = null;
            AudioBox.FillColor = Color.White;
            AudioBox.Font = new Font("Microsoft Sans Serif", 12F);
            AudioBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            AudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
            AudioBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            AudioBox.Location = new Point(777, 141);
            AudioBox.Margin = new Padding(4, 5, 4, 5);
            AudioBox.MinimumSize = new Size(63, 0);
            AudioBox.Name = "AudioBox";
            AudioBox.Padding = new Padding(0, 0, 30, 2);
            AudioBox.RectColor = Color.Black;
            AudioBox.Size = new Size(150, 29);
            AudioBox.SymbolSize = 24;
            AudioBox.TabIndex = 36;
            AudioBox.Text = "Dublado";
            AudioBox.TextAlignment = ContentAlignment.MiddleLeft;
            AudioBox.Watermark = "Áudio";
            // 
            // TituloText
            // 
            TituloText.Font = new Font("Microsoft Sans Serif", 12F);
            TituloText.Location = new Point(213, 141);
            TituloText.Margin = new Padding(4, 5, 4, 5);
            TituloText.MinimumSize = new Size(1, 16);
            TituloText.Name = "TituloText";
            TituloText.Padding = new Padding(5);
            TituloText.RectColor = Color.Black;
            TituloText.ShowText = false;
            TituloText.Size = new Size(556, 29);
            TituloText.TabIndex = 38;
            TituloText.TextAlignment = ContentAlignment.MiddleLeft;
            TituloText.Watermark = "Título";
            // 
            // AudioLabel
            // 
            AudioLabel.AutoSize = true;
            AudioLabel.Font = new Font("Microsoft Sans Serif", 12F);
            AudioLabel.ForeColor = Color.Black;
            AudioLabel.Location = new Point(777, 116);
            AudioLabel.Name = "AudioLabel";
            AudioLabel.Size = new Size(50, 20);
            AudioLabel.TabIndex = 37;
            AudioLabel.Text = "Áudio";
            // 
            // TituloOriginalText
            // 
            TituloOriginalText.Font = new Font("Microsoft Sans Serif", 12F);
            TituloOriginalText.Location = new Point(44, 359);
            TituloOriginalText.Margin = new Padding(4, 5, 4, 5);
            TituloOriginalText.MinimumSize = new Size(1, 16);
            TituloOriginalText.Name = "TituloOriginalText";
            TituloOriginalText.Padding = new Padding(5);
            TituloOriginalText.RectColor = Color.Black;
            TituloOriginalText.ShowText = false;
            TituloOriginalText.Size = new Size(699, 29);
            TituloOriginalText.TabIndex = 37;
            TituloOriginalText.TextAlignment = ContentAlignment.MiddleLeft;
            TituloOriginalText.Watermark = "Título Original";
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloLabel.ForeColor = Color.Black;
            TituloLabel.Location = new Point(213, 116);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(47, 20);
            TituloLabel.TabIndex = 36;
            TituloLabel.Text = "Título";
            // 
            // DataLancamentoText
            // 
            DataLancamentoText.Font = new Font("Microsoft Sans Serif", 12F);
            DataLancamentoText.Location = new Point(751, 359);
            DataLancamentoText.Margin = new Padding(4, 5, 4, 5);
            DataLancamentoText.MinimumSize = new Size(1, 16);
            DataLancamentoText.Name = "DataLancamentoText";
            DataLancamentoText.Padding = new Padding(5);
            DataLancamentoText.RectColor = Color.Black;
            DataLancamentoText.ShowText = false;
            DataLancamentoText.Size = new Size(176, 29);
            DataLancamentoText.TabIndex = 37;
            DataLancamentoText.TextAlignment = ContentAlignment.MiddleLeft;
            DataLancamentoText.Watermark = "Data de Lançamento";
            // 
            // DataLancamentoLabel
            // 
            DataLancamentoLabel.AutoSize = true;
            DataLancamentoLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DataLancamentoLabel.ForeColor = Color.Black;
            DataLancamentoLabel.Location = new Point(750, 335);
            DataLancamentoLabel.Name = "DataLancamentoLabel";
            DataLancamentoLabel.Size = new Size(159, 20);
            DataLancamentoLabel.TabIndex = 36;
            DataLancamentoLabel.Text = "Data de Lançamento";
            // 
            // TituloAlternativoText
            // 
            TituloAlternativoText.Font = new Font("Microsoft Sans Serif", 12F);
            TituloAlternativoText.Location = new Point(44, 418);
            TituloAlternativoText.Margin = new Padding(4, 5, 4, 5);
            TituloAlternativoText.MinimumSize = new Size(1, 16);
            TituloAlternativoText.Name = "TituloAlternativoText";
            TituloAlternativoText.Padding = new Padding(5);
            TituloAlternativoText.RectColor = Color.Black;
            TituloAlternativoText.ShowText = false;
            TituloAlternativoText.Size = new Size(699, 29);
            TituloAlternativoText.TabIndex = 37;
            TituloAlternativoText.Text = "--";
            TituloAlternativoText.TextAlignment = ContentAlignment.MiddleLeft;
            TituloAlternativoText.Watermark = "Título Alternativo";
            // 
            // FranquiaLabel
            // 
            FranquiaLabel.AutoSize = true;
            FranquiaLabel.Font = new Font("Microsoft Sans Serif", 12F);
            FranquiaLabel.ForeColor = Color.Black;
            FranquiaLabel.Location = new Point(44, 511);
            FranquiaLabel.Name = "FranquiaLabel";
            FranquiaLabel.Size = new Size(72, 20);
            FranquiaLabel.TabIndex = 36;
            FranquiaLabel.Text = "Franquia";
            // 
            // Fra
            // 
            Fra.AutoSize = true;
            Fra.Font = new Font("Microsoft Sans Serif", 12F);
            Fra.ForeColor = Color.Black;
            Fra.Location = new Point(751, 453);
            Fra.Name = "Fra";
            Fra.Size = new Size(85, 20);
            Fra.TabIndex = 36;
            Fra.Text = "Fase MCU";
            // 
            // uiTextBox7
            // 
            uiTextBox7.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox7.Location = new Point(44, 536);
            uiTextBox7.Margin = new Padding(4, 5, 4, 5);
            uiTextBox7.MinimumSize = new Size(1, 16);
            uiTextBox7.Name = "uiTextBox7";
            uiTextBox7.Padding = new Padding(5);
            uiTextBox7.RectColor = Color.Black;
            uiTextBox7.ShowText = false;
            uiTextBox7.Size = new Size(883, 29);
            uiTextBox7.TabIndex = 37;
            uiTextBox7.Text = "--";
            uiTextBox7.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox7.Watermark = "Franquia";
            // 
            // TituloOriginalLabel
            // 
            TituloOriginalLabel.AutoSize = true;
            TituloOriginalLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloOriginalLabel.ForeColor = Color.Black;
            TituloOriginalLabel.Location = new Point(41, 334);
            TituloOriginalLabel.Name = "TituloOriginalLabel";
            TituloOriginalLabel.Size = new Size(104, 20);
            TituloOriginalLabel.TabIndex = 36;
            TituloOriginalLabel.Text = "Título Original";
            // 
            // TagsText
            // 
            TagsText.Font = new Font("Microsoft Sans Serif", 12F);
            TagsText.Location = new Point(751, 419);
            TagsText.Margin = new Padding(4, 5, 4, 5);
            TagsText.MinimumSize = new Size(1, 16);
            TagsText.Name = "TagsText";
            TagsText.Padding = new Padding(5);
            TagsText.RectColor = Color.Black;
            TagsText.ShowText = false;
            TagsText.Size = new Size(176, 29);
            TagsText.TabIndex = 37;
            TagsText.TextAlignment = ContentAlignment.MiddleLeft;
            TagsText.Watermark = "Tags";
            // 
            // TituloAlternativoLabel
            // 
            TituloAlternativoLabel.AutoSize = true;
            TituloAlternativoLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloAlternativoLabel.ForeColor = Color.Black;
            TituloAlternativoLabel.Location = new Point(41, 394);
            TituloAlternativoLabel.Name = "TituloAlternativoLabel";
            TituloAlternativoLabel.Size = new Size(126, 20);
            TituloAlternativoLabel.TabIndex = 36;
            TituloAlternativoLabel.Text = "Título Alternativo";
            // 
            // GeneroText
            // 
            GeneroText.Font = new Font("Microsoft Sans Serif", 12F);
            GeneroText.Location = new Point(44, 595);
            GeneroText.Margin = new Padding(4, 5, 4, 5);
            GeneroText.MinimumSize = new Size(1, 16);
            GeneroText.Name = "GeneroText";
            GeneroText.Padding = new Padding(5);
            GeneroText.RectColor = Color.Black;
            GeneroText.ShowText = false;
            GeneroText.Size = new Size(883, 29);
            GeneroText.TabIndex = 37;
            GeneroText.TextAlignment = ContentAlignment.MiddleLeft;
            GeneroText.Watermark = "Gênero";
            // 
            // FilmeLabel
            // 
            FilmeLabel.AutoSize = true;
            FilmeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            FilmeLabel.ForeColor = Color.Black;
            FilmeLabel.Location = new Point(41, 452);
            FilmeLabel.Name = "FilmeLabel";
            FilmeLabel.Size = new Size(47, 20);
            FilmeLabel.TabIndex = 36;
            FilmeLabel.Text = "Filme";
            // 
            // FilmeText
            // 
            FilmeText.Font = new Font("Microsoft Sans Serif", 12F);
            FilmeText.Location = new Point(44, 477);
            FilmeText.Margin = new Padding(4, 5, 4, 5);
            FilmeText.MinimumSize = new Size(1, 16);
            FilmeText.Name = "FilmeText";
            FilmeText.Padding = new Padding(5);
            FilmeText.RectColor = Color.Black;
            FilmeText.ShowText = false;
            FilmeText.Size = new Size(699, 29);
            FilmeText.TabIndex = 37;
            FilmeText.TextAlignment = ContentAlignment.MiddleLeft;
            FilmeText.Watermark = "Filme";
            // 
            // SinopseLabel
            // 
            SinopseLabel.AutoSize = true;
            SinopseLabel.Font = new Font("Microsoft Sans Serif", 12F);
            SinopseLabel.ForeColor = Color.Black;
            SinopseLabel.Location = new Point(41, 175);
            SinopseLabel.Name = "SinopseLabel";
            SinopseLabel.Size = new Size(67, 20);
            SinopseLabel.TabIndex = 36;
            SinopseLabel.Text = "Sinopse";
            // 
            // TagsLabel
            // 
            TagsLabel.AutoSize = true;
            TagsLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TagsLabel.ForeColor = Color.Black;
            TagsLabel.Location = new Point(750, 394);
            TagsLabel.Name = "TagsLabel";
            TagsLabel.Size = new Size(44, 20);
            TagsLabel.TabIndex = 39;
            TagsLabel.Text = "Tags";
            // 
            // uiLabel12
            // 
            uiLabel12.AutoSize = true;
            uiLabel12.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel12.ForeColor = Color.Black;
            uiLabel12.Location = new Point(41, 688);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(67, 20);
            uiLabel12.TabIndex = 40;
            uiLabel12.Text = "Estrelas";
            // 
            // uiLabel13
            // 
            uiLabel13.AutoSize = true;
            uiLabel13.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel13.ForeColor = Color.Black;
            uiLabel13.Location = new Point(44, 747);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new Size(63, 20);
            uiLabel13.TabIndex = 41;
            uiLabel13.Text = "Estúdio";
            // 
            // uiLabel14
            // 
            uiLabel14.AutoSize = true;
            uiLabel14.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel14.ForeColor = Color.Black;
            uiLabel14.Location = new Point(41, 570);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new Size(63, 20);
            uiLabel14.TabIndex = 42;
            uiLabel14.Text = "Gênero";
            // 
            // uiLabel15
            // 
            uiLabel15.AutoSize = true;
            uiLabel15.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel15.ForeColor = Color.Black;
            uiLabel15.Location = new Point(41, 629);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new Size(57, 20);
            uiLabel15.TabIndex = 43;
            uiLabel15.Text = "Diretor";
            // 
            // DiretorText
            // 
            DiretorText.Font = new Font("Microsoft Sans Serif", 12F);
            DiretorText.Location = new Point(44, 654);
            DiretorText.Margin = new Padding(4, 5, 4, 5);
            DiretorText.MinimumSize = new Size(1, 16);
            DiretorText.Name = "DiretorText";
            DiretorText.Padding = new Padding(5);
            DiretorText.RectColor = Color.Black;
            DiretorText.ShowText = false;
            DiretorText.Size = new Size(883, 29);
            DiretorText.TabIndex = 38;
            DiretorText.TextAlignment = ContentAlignment.MiddleLeft;
            DiretorText.Watermark = "Diretor";
            // 
            // EstrelasText
            // 
            EstrelasText.Font = new Font("Microsoft Sans Serif", 12F);
            EstrelasText.Location = new Point(44, 713);
            EstrelasText.Margin = new Padding(4, 5, 4, 5);
            EstrelasText.MinimumSize = new Size(1, 16);
            EstrelasText.Name = "EstrelasText";
            EstrelasText.Padding = new Padding(5);
            EstrelasText.RectColor = Color.Black;
            EstrelasText.ShowText = false;
            EstrelasText.Size = new Size(883, 29);
            EstrelasText.TabIndex = 38;
            EstrelasText.TextAlignment = ContentAlignment.MiddleLeft;
            EstrelasText.Watermark = "Estrelas";
            // 
            // EstudioText
            // 
            EstudioText.Font = new Font("Microsoft Sans Serif", 12F);
            EstudioText.Location = new Point(44, 772);
            EstudioText.Margin = new Padding(4, 5, 4, 5);
            EstudioText.MinimumSize = new Size(1, 16);
            EstudioText.Name = "EstudioText";
            EstudioText.Padding = new Padding(5);
            EstudioText.RectColor = Color.Black;
            EstudioText.ShowText = false;
            EstudioText.Size = new Size(883, 29);
            EstudioText.TabIndex = 38;
            EstudioText.TextAlignment = ContentAlignment.MiddleLeft;
            EstudioText.Watermark = "Estúdio";
            // 
            // FaseMCUText
            // 
            FaseMCUText.Font = new Font("Microsoft Sans Serif", 12F);
            FaseMCUText.Location = new Point(751, 478);
            FaseMCUText.Margin = new Padding(4, 5, 4, 5);
            FaseMCUText.MinimumSize = new Size(1, 16);
            FaseMCUText.Name = "FaseMCUText";
            FaseMCUText.Padding = new Padding(5);
            FaseMCUText.RectColor = Color.Black;
            FaseMCUText.ShowText = false;
            FaseMCUText.Size = new Size(176, 29);
            FaseMCUText.TabIndex = 38;
            FaseMCUText.Text = "--";
            FaseMCUText.TextAlignment = ContentAlignment.MiddleLeft;
            FaseMCUText.Watermark = "";
            // 
            // ResumoText
            // 
            ResumoText.FillColor = Color.White;
            ResumoText.Font = new Font("Microsoft Sans Serif", 12F);
            ResumoText.Location = new Point(935, 201);
            ResumoText.Margin = new Padding(4, 5, 4, 5);
            ResumoText.MinimumSize = new Size(1, 1);
            ResumoText.Name = "ResumoText";
            ResumoText.Padding = new Padding(2);
            ResumoText.RectColor = Color.Black;
            ResumoText.ShowText = false;
            ResumoText.Size = new Size(527, 600);
            ResumoText.TabIndex = 45;
            ResumoText.TextAlignment = ContentAlignment.TopLeft;
            // 
            // SinopseText
            // 
            SinopseText.FillColor = Color.White;
            SinopseText.Font = new Font("Microsoft Sans Serif", 12F);
            SinopseText.Location = new Point(44, 201);
            SinopseText.Margin = new Padding(4, 5, 4, 5);
            SinopseText.MinimumSize = new Size(1, 1);
            SinopseText.Name = "SinopseText";
            SinopseText.Padding = new Padding(2);
            SinopseText.RectColor = Color.Black;
            SinopseText.ShowText = false;
            SinopseText.Size = new Size(876, 129);
            SinopseText.TabIndex = 46;
            SinopseText.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            materialButton1.Font = new Font("Microsoft Sans Serif", 12F);
            materialButton1.ForeColor = Color.Black;
            materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.ContentCopy;
            materialButton1.IconColor = Color.Black;
            materialButton1.Location = new Point(182, 827);
            materialButton1.Name = "materialButton1";
            materialButton1.Size = new Size(198, 91);
            materialButton1.TabIndex = 47;
            materialButton1.Text = "Copiar";
            materialButton1.TextAlign = ContentAlignment.BottomLeft;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.Font = new Font("Microsoft Sans Serif", 12F);
            materialButton2.ForeColor = Color.Black;
            materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.ContentSave;
            materialButton2.IconColor = Color.Black;
            materialButton2.Location = new Point(411, 827);
            materialButton2.Name = "materialButton2";
            materialButton2.Size = new Size(198, 91);
            materialButton2.TabIndex = 48;
            materialButton2.Text = "Inserir Novo";
            materialButton2.TextAlign = ContentAlignment.BottomLeft;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.Font = new Font("Microsoft Sans Serif", 12F);
            materialButton3.ForeColor = Color.Black;
            materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.FileEdit;
            materialButton3.IconColor = Color.Black;
            materialButton3.Location = new Point(652, 827);
            materialButton3.Name = "materialButton3";
            materialButton3.Size = new Size(198, 91);
            materialButton3.TabIndex = 49;
            materialButton3.Text = "Editar ";
            materialButton3.TextAlign = ContentAlignment.BottomLeft;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            materialButton4.Font = new Font("Microsoft Sans Serif", 12F);
            materialButton4.ForeColor = Color.Black;
            materialButton4.IconChar = FontAwesome.Sharp.MaterialIcons.SkipPrevious;
            materialButton4.IconColor = Color.Black;
            materialButton4.Location = new Point(894, 827);
            materialButton4.Name = "materialButton4";
            materialButton4.Size = new Size(198, 91);
            materialButton4.TabIndex = 50;
            materialButton4.Text = "Anterior";
            materialButton4.TextAlign = ContentAlignment.BottomLeft;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            materialButton5.Font = new Font("Microsoft Sans Serif", 12F);
            materialButton5.ForeColor = Color.Black;
            materialButton5.IconChar = FontAwesome.Sharp.MaterialIcons.SkipNext;
            materialButton5.IconColor = Color.Black;
            materialButton5.Location = new Point(1122, 827);
            materialButton5.Name = "materialButton5";
            materialButton5.Size = new Size(198, 91);
            materialButton5.TabIndex = 51;
            materialButton5.Text = "Proximo";
            materialButton5.TextAlign = ContentAlignment.BottomLeft;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // uiLabel16
            // 
            uiLabel16.AutoSize = true;
            uiLabel16.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel16.ForeColor = Color.White;
            uiLabel16.Location = new Point(926, 58);
            uiLabel16.Name = "uiLabel16";
            uiLabel16.Size = new Size(56, 20);
            uiLabel16.TabIndex = 52;
            uiLabel16.Text = "Dados";
            // 
            // FilmesView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1485, 1023);
            Controls.Add(uiLabel16);
            Controls.Add(materialButton5);
            Controls.Add(materialButton4);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(SinopseText);
            Controls.Add(ResumoText);
            Controls.Add(DiretorText);
            Controls.Add(EstrelasText);
            Controls.Add(EstudioText);
            Controls.Add(FaseMCUText);
            Controls.Add(uiLabel15);
            Controls.Add(uiLabel14);
            Controls.Add(uiLabel13);
            Controls.Add(uiLabel12);
            Controls.Add(TagsLabel);
            Controls.Add(GeneroText);
            Controls.Add(uiTextBox7);
            Controls.Add(TagsText);
            Controls.Add(Fra);
            Controls.Add(TituloAlternativoLabel);
            Controls.Add(FilmeLabel);
            Controls.Add(DataLancamentoText);
            Controls.Add(TituloOriginalLabel);
            Controls.Add(TituloOriginalText);
            Controls.Add(TituloAlternativoText);
            Controls.Add(FilmeText);
            Controls.Add(DataLancamentoLabel);
            Controls.Add(TituloLabel);
            Controls.Add(FranquiaLabel);
            Controls.Add(SinopseLabel);
            Controls.Add(TituloText);
            Controls.Add(AudioLabel);
            Controls.Add(AudioBox);
            Controls.Add(CodigoText);
            Controls.Add(CodigoFilmeLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilmesView";
            Text = "Filmes";
            ZoomScaleRect = new Rectangle(15, 15, 1209, 709);
            Load += FilmesView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UILabel CodigoFilmeLabel;
        private Sunny.UI.UITextBox CodigoText;
        private Sunny.UI.UIComboBox AudioBox;
        private Sunny.UI.UITextBox TituloText;
        private Sunny.UI.UILabel AudioLabel;
        private Sunny.UI.UITextBox TituloOriginalText;
        private Sunny.UI.UILabel TituloLabel;
        private Sunny.UI.UITextBox DataLancamentoText;
        private Sunny.UI.UILabel DataLancamentoLabel;
        private Sunny.UI.UITextBox TituloAlternativoText;
        private Sunny.UI.UILabel FranquiaLabel;
        private Sunny.UI.UILabel Fra;
        private Sunny.UI.UITextBox uiTextBox7;
        private Sunny.UI.UILabel TituloOriginalLabel;
        private Sunny.UI.UITextBox TagsText;
        private Sunny.UI.UILabel TituloAlternativoLabel;
        private Sunny.UI.UITextBox GeneroText;
        private Sunny.UI.UILabel FilmeLabel;
        private Sunny.UI.UITextBox FilmeText;
        private Sunny.UI.UILabel SinopseLabel;
        private Sunny.UI.UITextBox DiretorText;
        private Sunny.UI.UITextBox EstrelasText;
        private Sunny.UI.UITextBox EstudioText;
        private Sunny.UI.UILabel TagsLabel;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UITextBox FaseMCUText;
        private Sunny.UI.UIRichTextBox ResumoText;
        private Sunny.UI.UIRichTextBox SinopseText;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private FontAwesome.Sharp.Material.MaterialButton materialButton2;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private FontAwesome.Sharp.Material.MaterialButton materialButton4;
        private FontAwesome.Sharp.Material.MaterialButton materialButton5;
        private Sunny.UI.UILabel uiLabel16;
    }
}