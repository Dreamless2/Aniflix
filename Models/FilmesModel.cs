using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Models
{
    public class FilmesModel
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopse { get; set; }
        public string? TituloOriginal { get; set; }
        public string? DataLancamento { get; set; }
        public string? Tags { get; set; }
        public string? Genero { get; set; }
        public string? Diretor { get; set; }

        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }
        public string? Titulo_Alternativo { get; set; }

    }
}
