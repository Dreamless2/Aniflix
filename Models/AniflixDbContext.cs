using Microsoft.EntityFrameworkCore;

namespace Aniflix.Models
{
    public class AniflixDbContext(DbContextOptions<AniflixDbContext> options) : DbContext(options)
    {
        public DbSet<Filme> Filmes { get; set; }
    }


}