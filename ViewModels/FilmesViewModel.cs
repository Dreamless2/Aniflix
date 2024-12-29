using System.ComponentModel;

namespace Aniflix.ViewModels
{
    public class FilmesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string? txTitulo;
        private string? txSinopse;
        private string? txTituloOriginal;
        private string? txDataLancamento;
        private string? txFranquia;
        private string? txGenero;
        private string? txTags;
        private string? txDiretor;
        private string? txElenco;
        private string? txEstudio;
        private string? cbAudio;
        public FilmesViewModel()
        {
            PropertyChanged = null;
        }

        public string TxTitulo
        {
            get => txTitulo!;
            set
            {
                txTitulo = value;
                OnPropertyChanged(nameof(TxTitulo));
                UpdateFormattedText();
            }
        }
        public string CbAudio
        {
            get => cbAudio!;
            set
            {
                cbAudio = value;
                OnPropertyChanged(nameof(CbAudio));
                UpdateFormattedText();
            }
        }

        public string TxSinopse
        {
            get => txSinopse!;
            set
            {
                txSinopse = value;
                OnPropertyChanged(nameof(TxSinopse));
                UpdateFormattedText();
            }
        }
        public string TxTituloOriginal
        {
            get => txTituloOriginal!;
            set
            {
                txTituloOriginal = value;
                OnPropertyChanged(nameof(TxTituloOriginal));
                UpdateFormattedText();
            }
        }
        public string TxDataLancamento
        {
            get => txDataLancamento!;
            set
            {
                txDataLancamento = value;
                OnPropertyChanged(nameof(TxDataLancamento));
                UpdateFormattedText();
            }
        }

        public string TxFranquia
        {
            get => txFranquia!;
            set
            {
                txFranquia = value;
                OnPropertyChanged(nameof(TxFranquia));
                UpdateFormattedText();
            }
        }

        public string TxGenero
        {
            get => txGenero!;
            set
            {
                txGenero = value;
                OnPropertyChanged(nameof(TxGenero));
                UpdateFormattedText();
            }
        }

        public string TxTags
        {
            get => txTags!;
            set
            {
                txTags = value;
                OnPropertyChanged(nameof(TxTags));
                UpdateFormattedText();
            }
        }

        public string TxDiretor
        {
            get => txDiretor!;
            set
            {
                txDiretor = value;
                OnPropertyChanged(nameof(TxDiretor));
                UpdateFormattedText();
            }
        }

        public string TxElenco
        {
            get => txElenco!;
            set
            {
                txElenco = value;
                OnPropertyChanged(nameof(TxElenco));
                UpdateFormattedText();
            }
        }

        public string TxEstudio
        {
            get => txEstudio!;
            set
            {
                txEstudio = value;
                OnPropertyChanged(nameof(TxEstudio));
                UpdateFormattedText();
            }
        }

        // Property for the formatted text shown in the large TextBox
        private string? formattedText;
        public string FormattedText
        {
            get => formattedText!;
            set
            {
                formattedText = value;
                OnPropertyChanged(nameof(FormattedText));
            }
        }

        private void UpdateFormattedText()
        {
            // Format the text dynamically based on the entered values
            FormattedText = $@"
        **{TxTitulo}** - **{CbAudio}**
                
        **HD** - __720p__
        **SD** - __480p__
        __[Os vídeos estão em ordem crescente, ou seja, de cima para baixo, tal como na descrição das resoluções.]__
        **Sinopse:** __{TxSinopse}__

        **Título Original:** __{TxTituloOriginal}__
        **Data de lançamento:** __{TxDataLancamento}__
        **Filme:** {TxTitulo}
        **Franquia:** {TxFranquia}
        **Gênero:** {TxGenero}
        **Tags:** {TxTags}
        **Diretor:** {TxDiretor}
        **Estrelas:** {TxElenco}
        **Estúdio:** {TxEstudio}
        ";
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}