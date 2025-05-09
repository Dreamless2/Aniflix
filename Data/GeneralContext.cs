#region "Copyright"
/***********************************************************************************
* Copyright (C) 2025  Tiago.NET
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
**********************************************************************************/
#endregion

using Aniflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Aniflix.Data
{
    public class GeneralContext : DbContext
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
