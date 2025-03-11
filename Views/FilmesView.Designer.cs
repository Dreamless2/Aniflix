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
            FaseMCULabel = new Sunny.UI.UILabel();
            uiTextBox7 = new Sunny.UI.UITextBox();
            TituloOriginalLabel = new Sunny.UI.UILabel();
            TagsText = new Sunny.UI.UITextBox();
            TituloAlternativoLabel = new Sunny.UI.UILabel();
            GeneroText = new Sunny.UI.UITextBox();
            FilmeLabel = new Sunny.UI.UILabel();
            FilmeText = new Sunny.UI.UITextBox();
            SinopseLabel = new Sunny.UI.UILabel();
            TagsLabel = new Sunny.UI.UILabel();
            EstrelasLabel = new Sunny.UI.UILabel();
            EstudioLabel = new Sunny.UI.UILabel();
            GeneroLabel = new Sunny.UI.UILabel();
            DiretorLabel = new Sunny.UI.UILabel();
            DiretorText = new Sunny.UI.UITextBox();
            EstrelasText = new Sunny.UI.UITextBox();
            EstudioText = new Sunny.UI.UITextBox();
            FaseMCUText = new Sunny.UI.UITextBox();
            ResumoText = new Sunny.UI.UIRichTextBox();
            SinopseText = new Sunny.UI.UIRichTextBox();
            CopiarButton = new FontAwesome.Sharp.Material.MaterialButton();
            InserirNovoButton = new FontAwesome.Sharp.Material.MaterialButton();
            EditarButton = new FontAwesome.Sharp.Material.MaterialButton();
            AnteriorButton = new FontAwesome.Sharp.Material.MaterialButton();
            ProximoButton = new FontAwesome.Sharp.Material.MaterialButton();
            DadosLabel = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // CodigoFilmeLabel
            // 
            CodigoFilmeLabel.AutoSize = true;
            CodigoFilmeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            CodigoFilmeLabel.ForeColor = Color.Black;
            CodigoFilmeLabel.Location = new Point(30, 62);
            CodigoFilmeLabel.Name = "CodigoFilmeLabel";
            CodigoFilmeLabel.Size = new Size(123, 20);
            CodigoFilmeLabel.TabIndex = 34;
            CodigoFilmeLabel.Text = "Código do Filme";
            // 
            // CodigoText
            // 
            CodigoText.Font = new Font("Microsoft Sans Serif", 12F);
            CodigoText.Location = new Point(30, 87);
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
            CodigoText.WordWarp = false;
            // 
            // AudioBox
            // 
            AudioBox.DataSource = null;
            AudioBox.FillColor = Color.White;
            AudioBox.Font = new Font("Microsoft Sans Serif", 12F);
            AudioBox.ItemHoverColor = Color.FromArgb(155, 200, 255);
            AudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
            AudioBox.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            AudioBox.Location = new Point(763, 87);
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
            TituloText.Location = new Point(199, 87);
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
            TituloText.WordWarp = false;
            // 
            // AudioLabel
            // 
            AudioLabel.AutoSize = true;
            AudioLabel.Font = new Font("Microsoft Sans Serif", 12F);
            AudioLabel.ForeColor = Color.Black;
            AudioLabel.Location = new Point(763, 62);
            AudioLabel.Name = "AudioLabel";
            AudioLabel.Size = new Size(50, 20);
            AudioLabel.TabIndex = 37;
            AudioLabel.Text = "Áudio";
            // 
            // TituloOriginalText
            // 
            TituloOriginalText.Font = new Font("Microsoft Sans Serif", 12F);
            TituloOriginalText.Location = new Point(30, 305);
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
            TituloOriginalText.WordWarp = false;
            // 
            // TituloLabel
            // 
            TituloLabel.AutoSize = true;
            TituloLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloLabel.ForeColor = Color.Black;
            TituloLabel.Location = new Point(199, 62);
            TituloLabel.Name = "TituloLabel";
            TituloLabel.Size = new Size(47, 20);
            TituloLabel.TabIndex = 36;
            TituloLabel.Text = "Título";
            // 
            // DataLancamentoText
            // 
            DataLancamentoText.Font = new Font("Microsoft Sans Serif", 12F);
            DataLancamentoText.Location = new Point(737, 305);
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
            DataLancamentoText.WordWarp = false;
            // 
            // DataLancamentoLabel
            // 
            DataLancamentoLabel.AutoSize = true;
            DataLancamentoLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DataLancamentoLabel.ForeColor = Color.Black;
            DataLancamentoLabel.Location = new Point(736, 281);
            DataLancamentoLabel.Name = "DataLancamentoLabel";
            DataLancamentoLabel.Size = new Size(159, 20);
            DataLancamentoLabel.TabIndex = 36;
            DataLancamentoLabel.Text = "Data de Lançamento";
            // 
            // TituloAlternativoText
            // 
            TituloAlternativoText.Font = new Font("Microsoft Sans Serif", 12F);
            TituloAlternativoText.Location = new Point(30, 364);
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
            TituloAlternativoText.WordWarp = false;
            // 
            // FranquiaLabel
            // 
            FranquiaLabel.AutoSize = true;
            FranquiaLabel.Font = new Font("Microsoft Sans Serif", 12F);
            FranquiaLabel.ForeColor = Color.Black;
            FranquiaLabel.Location = new Point(30, 457);
            FranquiaLabel.Name = "FranquiaLabel";
            FranquiaLabel.Size = new Size(72, 20);
            FranquiaLabel.TabIndex = 36;
            FranquiaLabel.Text = "Franquia";
            // 
            // FaseMCULabel
            // 
            FaseMCULabel.AutoSize = true;
            FaseMCULabel.Font = new Font("Microsoft Sans Serif", 12F);
            FaseMCULabel.ForeColor = Color.Black;
            FaseMCULabel.Location = new Point(737, 399);
            FaseMCULabel.Name = "FaseMCULabel";
            FaseMCULabel.Size = new Size(85, 20);
            FaseMCULabel.TabIndex = 36;
            FaseMCULabel.Text = "Fase MCU";
            // 
            // uiTextBox7
            // 
            uiTextBox7.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox7.Location = new Point(30, 482);
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
            uiTextBox7.WordWarp = false;
            // 
            // TituloOriginalLabel
            // 
            TituloOriginalLabel.AutoSize = true;
            TituloOriginalLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloOriginalLabel.ForeColor = Color.Black;
            TituloOriginalLabel.Location = new Point(30, 280);
            TituloOriginalLabel.Name = "TituloOriginalLabel";
            TituloOriginalLabel.Size = new Size(104, 20);
            TituloOriginalLabel.TabIndex = 36;
            TituloOriginalLabel.Text = "Título Original";
            // 
            // TagsText
            // 
            TagsText.Font = new Font("Microsoft Sans Serif", 12F);
            TagsText.Location = new Point(737, 365);
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
            TagsText.WordWarp = false;
            // 
            // TituloAlternativoLabel
            // 
            TituloAlternativoLabel.AutoSize = true;
            TituloAlternativoLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TituloAlternativoLabel.ForeColor = Color.Black;
            TituloAlternativoLabel.Location = new Point(30, 340);
            TituloAlternativoLabel.Name = "TituloAlternativoLabel";
            TituloAlternativoLabel.Size = new Size(126, 20);
            TituloAlternativoLabel.TabIndex = 36;
            TituloAlternativoLabel.Text = "Título Alternativo";
            // 
            // GeneroText
            // 
            GeneroText.Font = new Font("Microsoft Sans Serif", 12F);
            GeneroText.Location = new Point(30, 541);
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
            GeneroText.WordWarp = false;
            // 
            // FilmeLabel
            // 
            FilmeLabel.AutoSize = true;
            FilmeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            FilmeLabel.ForeColor = Color.Black;
            FilmeLabel.Location = new Point(30, 398);
            FilmeLabel.Name = "FilmeLabel";
            FilmeLabel.Size = new Size(47, 20);
            FilmeLabel.TabIndex = 36;
            FilmeLabel.Text = "Filme";
            // 
            // FilmeText
            // 
            FilmeText.Font = new Font("Microsoft Sans Serif", 12F);
            FilmeText.Location = new Point(30, 423);
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
            FilmeText.WordWarp = false;
            // 
            // SinopseLabel
            // 
            SinopseLabel.AutoSize = true;
            SinopseLabel.Font = new Font("Microsoft Sans Serif", 12F);
            SinopseLabel.ForeColor = Color.Black;
            SinopseLabel.Location = new Point(30, 121);
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
            TagsLabel.Location = new Point(737, 340);
            TagsLabel.Name = "TagsLabel";
            TagsLabel.Size = new Size(44, 20);
            TagsLabel.TabIndex = 39;
            TagsLabel.Text = "Tags";
            // 
            // EstrelasLabel
            // 
            EstrelasLabel.AutoSize = true;
            EstrelasLabel.Font = new Font("Microsoft Sans Serif", 12F);
            EstrelasLabel.ForeColor = Color.Black;
            EstrelasLabel.Location = new Point(30, 634);
            EstrelasLabel.Name = "EstrelasLabel";
            EstrelasLabel.Size = new Size(67, 20);
            EstrelasLabel.TabIndex = 40;
            EstrelasLabel.Text = "Estrelas";
            // 
            // EstudioLabel
            // 
            EstudioLabel.AutoSize = true;
            EstudioLabel.Font = new Font("Microsoft Sans Serif", 12F);
            EstudioLabel.ForeColor = Color.Black;
            EstudioLabel.Location = new Point(30, 693);
            EstudioLabel.Name = "EstudioLabel";
            EstudioLabel.Size = new Size(63, 20);
            EstudioLabel.TabIndex = 41;
            EstudioLabel.Text = "Estúdio";
            // 
            // GeneroLabel
            // 
            GeneroLabel.AutoSize = true;
            GeneroLabel.Font = new Font("Microsoft Sans Serif", 12F);
            GeneroLabel.ForeColor = Color.Black;
            GeneroLabel.Location = new Point(30, 516);
            GeneroLabel.Name = "GeneroLabel";
            GeneroLabel.Size = new Size(63, 20);
            GeneroLabel.TabIndex = 42;
            GeneroLabel.Text = "Gênero";
            // 
            // DiretorLabel
            // 
            DiretorLabel.AutoSize = true;
            DiretorLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DiretorLabel.ForeColor = Color.Black;
            DiretorLabel.Location = new Point(30, 575);
            DiretorLabel.Name = "DiretorLabel";
            DiretorLabel.Size = new Size(57, 20);
            DiretorLabel.TabIndex = 43;
            DiretorLabel.Text = "Diretor";
            // 
            // DiretorText
            // 
            DiretorText.Font = new Font("Microsoft Sans Serif", 12F);
            DiretorText.Location = new Point(30, 600);
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
            DiretorText.WordWarp = false;
            // 
            // EstrelasText
            // 
            EstrelasText.Font = new Font("Microsoft Sans Serif", 12F);
            EstrelasText.Location = new Point(30, 659);
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
            EstrelasText.WordWarp = false;
            // 
            // EstudioText
            // 
            EstudioText.Font = new Font("Microsoft Sans Serif", 12F);
            EstudioText.Location = new Point(30, 718);
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
            EstudioText.WordWarp = false;
            // 
            // FaseMCUText
            // 
            FaseMCUText.Font = new Font("Microsoft Sans Serif", 12F);
            FaseMCUText.Location = new Point(737, 423);
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
            FaseMCUText.WordWarp = false;
            // 
            // ResumoText
            // 
            ResumoText.FillColor = Color.White;
            ResumoText.Font = new Font("Microsoft Sans Serif", 12F);
            ResumoText.Location = new Point(921, 87);
            ResumoText.Margin = new Padding(4, 5, 4, 5);
            ResumoText.MinimumSize = new Size(1, 1);
            ResumoText.Name = "ResumoText";
            ResumoText.Padding = new Padding(2);
            ResumoText.RectColor = Color.Black;
            ResumoText.ShowText = false;
            ResumoText.Size = new Size(530, 660);
            ResumoText.TabIndex = 45;
            ResumoText.TextAlignment = ContentAlignment.TopLeft;
            // 
            // SinopseText
            // 
            SinopseText.FillColor = Color.White;
            SinopseText.Font = new Font("Microsoft Sans Serif", 12F);
            SinopseText.Location = new Point(30, 147);
            SinopseText.Margin = new Padding(4, 5, 4, 5);
            SinopseText.MinimumSize = new Size(1, 1);
            SinopseText.Name = "SinopseText";
            SinopseText.Padding = new Padding(2);
            SinopseText.RectColor = Color.Black;
            SinopseText.ShowText = false;
            SinopseText.Size = new Size(876, 129);
            SinopseText.TabIndex = 46;
            SinopseText.TextAlignment = ContentAlignment.TopLeft;
            // 
            // CopiarButton
            // 
            CopiarButton.Font = new Font("Microsoft Sans Serif", 12F);
            CopiarButton.ForeColor = Color.Black;
            CopiarButton.IconChar = FontAwesome.Sharp.MaterialIcons.ContentCopy;
            CopiarButton.IconColor = Color.Black;
            CopiarButton.Location = new Point(168, 773);
            CopiarButton.Name = "CopiarButton";
            CopiarButton.Size = new Size(198, 91);
            CopiarButton.TabIndex = 47;
            CopiarButton.Text = "Copiar";
            CopiarButton.TextAlign = ContentAlignment.BottomLeft;
            CopiarButton.UseVisualStyleBackColor = true;
            // 
            // InserirNovoButton
            // 
            InserirNovoButton.Font = new Font("Microsoft Sans Serif", 12F);
            InserirNovoButton.ForeColor = Color.Black;
            InserirNovoButton.IconChar = FontAwesome.Sharp.MaterialIcons.ContentSave;
            InserirNovoButton.IconColor = Color.Black;
            InserirNovoButton.Location = new Point(403, 773);
            InserirNovoButton.Name = "InserirNovoButton";
            InserirNovoButton.Size = new Size(198, 91);
            InserirNovoButton.TabIndex = 48;
            InserirNovoButton.Text = "Inserir Novo";
            InserirNovoButton.TextAlign = ContentAlignment.BottomLeft;
            InserirNovoButton.UseVisualStyleBackColor = true;
            // 
            // EditarButton
            // 
            EditarButton.Font = new Font("Microsoft Sans Serif", 12F);
            EditarButton.ForeColor = Color.Black;
            EditarButton.IconChar = FontAwesome.Sharp.MaterialIcons.FileEdit;
            EditarButton.IconColor = Color.Black;
            EditarButton.Location = new Point(638, 773);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(198, 91);
            EditarButton.TabIndex = 49;
            EditarButton.Text = "Editar ";
            EditarButton.TextAlign = ContentAlignment.BottomLeft;
            EditarButton.UseVisualStyleBackColor = true;
            // 
            // AnteriorButton
            // 
            AnteriorButton.Font = new Font("Microsoft Sans Serif", 12F);
            AnteriorButton.ForeColor = Color.Black;
            AnteriorButton.IconChar = FontAwesome.Sharp.MaterialIcons.SkipPrevious;
            AnteriorButton.IconColor = Color.Black;
            AnteriorButton.Location = new Point(873, 773);
            AnteriorButton.Name = "AnteriorButton";
            AnteriorButton.Size = new Size(198, 91);
            AnteriorButton.TabIndex = 50;
            AnteriorButton.Text = "Anterior";
            AnteriorButton.TextAlign = ContentAlignment.BottomLeft;
            AnteriorButton.UseVisualStyleBackColor = true;
            // 
            // ProximoButton
            // 
            ProximoButton.Font = new Font("Microsoft Sans Serif", 12F);
            ProximoButton.ForeColor = Color.Black;
            ProximoButton.IconChar = FontAwesome.Sharp.MaterialIcons.SkipNext;
            ProximoButton.IconColor = Color.Black;
            ProximoButton.Location = new Point(1108, 773);
            ProximoButton.Name = "ProximoButton";
            ProximoButton.Size = new Size(198, 91);
            ProximoButton.TabIndex = 51;
            ProximoButton.Text = "Proximo";
            ProximoButton.TextAlign = ContentAlignment.BottomLeft;
            ProximoButton.UseVisualStyleBackColor = true;
            // 
            // DadosLabel
            // 
            DadosLabel.AutoSize = true;
            DadosLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DadosLabel.ForeColor = Color.Black;
            DadosLabel.Location = new Point(921, 62);
            DadosLabel.Name = "DadosLabel";
            DadosLabel.Size = new Size(56, 20);
            DadosLabel.TabIndex = 52;
            DadosLabel.Text = "Dados";
            // 
            // FilmesView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 248, 248);
            ClientSize = new Size(1485, 899);
            ControlBox = false;
            ControlBoxFillHoverColor = Color.FromArgb(51, 171, 160);
            Controls.Add(DadosLabel);
            Controls.Add(ProximoButton);
            Controls.Add(FaseMCULabel);
            Controls.Add(AnteriorButton);
            Controls.Add(EditarButton);
            Controls.Add(InserirNovoButton);
            Controls.Add(CopiarButton);
            Controls.Add(SinopseText);
            Controls.Add(ResumoText);
            Controls.Add(DiretorText);
            Controls.Add(EstrelasText);
            Controls.Add(EstudioText);
            Controls.Add(FaseMCUText);
            Controls.Add(DiretorLabel);
            Controls.Add(GeneroLabel);
            Controls.Add(EstudioLabel);
            Controls.Add(EstrelasLabel);
            Controls.Add(TagsLabel);
            Controls.Add(GeneroText);
            Controls.Add(uiTextBox7);
            Controls.Add(TagsText);
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
            RectColor = Color.FromArgb(0, 150, 136);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Filmes";
            TitleColor = Color.FromArgb(0, 150, 136);
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
        private Sunny.UI.UILabel FaseMCULabel;
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
        private Sunny.UI.UILabel EstrelasLabel;
        private Sunny.UI.UILabel EstudioLabel;
        private Sunny.UI.UILabel GeneroLabel;
        private Sunny.UI.UILabel DiretorLabel;
        private Sunny.UI.UITextBox FaseMCUText;
        private Sunny.UI.UIRichTextBox ResumoText;
        private Sunny.UI.UIRichTextBox SinopseText;
        private FontAwesome.Sharp.Material.MaterialButton CopiarButton;
        private FontAwesome.Sharp.Material.MaterialButton InserirNovoButton;
        private FontAwesome.Sharp.Material.MaterialButton EditarButton;
        private FontAwesome.Sharp.Material.MaterialButton AnteriorButton;
        private FontAwesome.Sharp.Material.MaterialButton ProximoButton;
        private Sunny.UI.UILabel DadosLabel;
    }
}