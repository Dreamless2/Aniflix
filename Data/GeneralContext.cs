using Aniflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniflix.Data
{
    public class GeneralContext : DBContext
    {
        private static readonly string localConnectionString = "Server=localhost;Database=aniflix;Username=Covenant9687;Password=v*##GLBkB3r9tuUt;Port=3306;";
        public DbSet<FilmesModels> Filmes { get; set; }
        public DbSet<GoreFilmesModels> Gore_Filmes { get; set; }
        public DbSet<BreakOutFilmesModels> Breakout_Filmes { get; set; }
        public DbSet<SeriesModels> Series { get; set; }
        public DbSet<GoreSeriesModels> Gore_Series { get; set; }
        public DbSet<BreakOutSeriesModels> BreakOut_Series { get; set; }
        public DbSet<AnimesModels> Animes { get; set; }
        public DbSet<AnimesFilmesModels> Animes_Filmes { get; set; }
        public DbSet<TrashflixModels> Trashflix { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(localConnectionString, ServerVersion.AutoDetect(localConnectionString));
        }

    }
}
