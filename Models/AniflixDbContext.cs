using Microsoft.EntityFrameworkCore;

namespace Aniflix.Models
{
    public class AniflixDbContext(DbContextOptions<AniflixDbContext> options) : DbContext(options)
    {
        public DbSet<Filme> Filmes { get; set; }
    }

    public class Filme
    {
        public string? Codigo { get; set; }
        public string? Titulo { get; set; }
        public string? TituloOriginal { get; set; }
        public string? DataLancamento { get; set; }
        public string? Franquia { get; set; }
        public string? Genero { get; set; }
        public string? Tags { get; set; }
        public string? Diretor { get; set; }
        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }
        public string? Sinopse { get; set; }
    }
}