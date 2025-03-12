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

        public string? Audio { get; set; }
        public string? Sinopse { get; set; }
        public string? Titulo_Original { get; set; }
        public string? Data_Lancamento { get; set; }
        public string? Titulo_Alternativo { get; set; }

        public string? Filme { get; set; }

        public string? Franquia { get; set; }

        public string? Genero { get; set; }

        public string? Tags { get; set; }
        public string? Estrelas { get; set; }
        public string? Diretor { get; set; }

        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }


    }
}
