using System.ComponentModel.DataAnnotations.Schema;

namespace WatchFlix.Models
{
    [Table("animes")]
    public class AnimesModels
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Titulo { get; set; }
        public string? Audio { get; set; }
        public string? Sinopse { get; set; }
        public string? Titulo_Original { get; set; }
        public string? Data_Lancamento { get; set; }
        public string? Titulo_Alternativo { get; set; }
        public string? Franquia { get; set; }
        public string? Pais_Origem { get; set; }
        public string? Idioma_Original { get; set; }
        public string? Anime { get; set; }
        public string? Autores { get; set; }
        public string? Genero { get; set; }
        public string? Tags { get; set; }
        public string? Diretor { get; set; }
        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }
    }
}
