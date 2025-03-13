using System;
using System.Linq;
using System.Text;
using Aniflix.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Aniflix.Data
{
    public class GeneralContext : DbContext
    {
        private static readonly string localConnectionString = "Server=localhost;Database=aniflix;Username=Covenant9687;Password=v*##GLBkB3r9tuUt;Port=3306;";
        public DbSet<FilmesModels> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(localConnectionString, ServerVersion.AutoDetect(localConnectionString));
        }

    }
}
