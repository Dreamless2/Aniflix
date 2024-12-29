using System.ComponentModel;
using Aniflix.Data;
using Aniflix.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Aniflix.ViewModels
{
    public class FilmesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly AniflixDbContext _dbContext;

        private string? txCodigo;
        private string? txTitulo;
        private string? txSinopse;
        private string? txTituloOriginal;
        private string? txDataLancamento;
        private string? txFranquia;
        private string? txGenero;
        private string? txTags;
        private string? txDiretor;
        private string? txEstrelas;
        private string? txEstudio;
        private string? cbAudio;
        public FilmesViewModel()
        {
            PropertyChanged = null;
            _dbContext = new AniflixDbContext(options: new DbContextOptions<AniflixDbContext>());
        }

        public string TxCodigo
        {
            get => txCodigo!;
            set
            {
                txCodigo = value;
                OnPropertyChanged(nameof(TxCodigo));
                UpdateFormattedText();
            }
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

        public string TxEstrelas
        {
            get => txEstrelas!;
            set
            {
                txEstrelas = value;
                OnPropertyChanged(nameof(TxEstrelas));
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
            FormattedText = $@"
**{TxTitulo}** - **{CbAudio}**
               
**HD** - __720p__
**SD** - __480p__
__[Os vídeos estão em ordem crescente, ou seja, de cima para baixo, tal como na descrição das resoluções.]__

**Sinopse:** __{TxSinopse}__

**Título Original:** __{TxTituloOriginal}__
**Data de lançamento:** __{TxDataLancamento}__
**Filme:** #{TxTitulo.Replace(" ", string.Empty)}
**Franquia:** {TxFranquia}
**Gênero:** {TxGenero}
**Tags:** {TxTags}
**Diretor:** {TxDiretor}
**Estrelas:** {TxEstrelas}
**Estúdio:** {TxEstudio}
";
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Save()
        {
            var filme = new Filme
            {
                Codigo = TxCodigo,
                Titulo = TxTitulo,
                Sinopse = TxSinopse,
                TituloOriginal = TxTituloOriginal,
                DataLancamento = TxDataLancamento,
                Franquia = TxFranquia,
                Genero = TxGenero,
                Tags = TxTags,
                Diretor = TxDiretor,
                Estrelas = TxEstrelas,
                Estudio = TxEstudio
            };

            var codigo = new NpgsqlParameter("p_codigo", filme.Codigo);
            var titulo = new NpgsqlParameter("p_titulo", filme.Titulo);
            var sinopse = new NpgsqlParameter("p_sinopse", filme.Sinopse);
            var titulo_original = new NpgsqlParameter("p_titulo_original", filme.TituloOriginal);
            var data_lancamento = new NpgsqlParameter("p_data_lancamento", filme.DataLancamento);
            var franquia = new NpgsqlParameter("p_franquia", filme.Franquia);
            var genero = new NpgsqlParameter("p_genero", filme.Genero);
            var tags = new NpgsqlParameter("p_tags", filme.Tags);
            var diretor = new NpgsqlParameter("p_diretor", filme.Diretor);
            var estrelas = new NpgsqlParameter("p_estrelas", filme.Estrelas);
            var estudio = new NpgsqlParameter("p_estudio", filme.Estudio);
            _dbContext.Database.ExecuteSqlRaw("CALL insert_filmes(@p_codigo, @p_titulo, @p_sinopse, @p_titulo_original, @p_data_lancamento, @p_franquia, @p_genero, @p_tags, @p_diretor, @p_estrelas, @p_estudio)", codigo, titulo, sinopse, titulo_original, data_lancamento, franquia, genero, tags, diretor, estrelas, estudio);
        }
    }
}