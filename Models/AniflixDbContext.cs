using Aniflix.Data;
using Microsoft.EntityFrameworkCore;

namespace Aniflix.Models
{
    public class AniflixDbContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public AniflixDbContext(DbContextOptions<AniflixDbContext> options) : base(options)
        {
        }
    }
}