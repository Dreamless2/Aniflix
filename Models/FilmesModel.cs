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

using System.ComponentModel.DataAnnotations.Schema;

namespace Aniflix.Models
{
    [Table("filmes")]
    public class FilmesModels
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Titulo { get; set; }
        public string? Audio { get; set; }
        public string? Sinopse { get; set; }
        public string? Titulo_Original { get; set; }
        public string? Data_Lancamento { get; set; }
        public string? Titulo_Alternativo { get; set; }
        public string? Filme { get; set; }
        public string? Franquia { get; set; }
        public string? Genero { get; set; }
        public string? Tags { get; set; }
        public string? Diretor { get; set; }
        public string? MCU { get; set; }
        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }
    }
}