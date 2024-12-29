using Microsoft.EntityFrameworkCore;

namespace Aniflix
{
    public class AniflixDbContext : DbContext
    {
        public AniflixDbContext(DbContextOptions<AniflixDbContext> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }
    }

    public class Filme
    {
        public string? TxTitulo { get; set; }
        public string? TxTituloOriginal { get; set; }
        public string? TxDataLancamento { get; set; }
        public string? TxFranquia { get; set; }
        public string? TxGenero { get; set; }
        public string? TxTags { get; set; }
        public string? TxDiretor { get; set; }
        public string? TxEstrelas { get; set; }
        public string? TxEstudio { get; set; }
        public string? TxSinopse { get; set; }
    }
}