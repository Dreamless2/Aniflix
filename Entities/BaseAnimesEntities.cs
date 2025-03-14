﻿namespace Aniflix.Entities
{
    public class BaseAnimesEntities(string titulo, string audio, string sinopse = null!, string tituloOriginal = null!,
                  string dataLancamento = null!, string tituloAlternativo = null!, string franquia = null!, string paisOrigem = null!, string idiomaOriginal = null!,
                  string anime = null!, string autores = null!, string genero = null!, string tags = null!, string diretor = null!,
                  string estrelas = null!, string estudio = null!)
    {
        public string Titulo { get; private set; } = titulo;
        public string Audio { get; private set; } = audio;
        public string Sinopse { get; private set; } = sinopse;
        public string TituloOriginal { get; private set; } = tituloOriginal;
        public string DataLancamento { get; private set; } = dataLancamento;
        public string TituloAlternativo { get; private set; } = tituloAlternativo;
        public string Franquia { get; private set; } = franquia;
        public string PaisOrigem { get; private set; } = paisOrigem;
        public string IdiomaOriginal { get; private set; } = idiomaOriginal;
        public string Anime { get; private set; } = anime;
        public string Autores { get; private set; } = autores;
        public string Genero { get; private set; } = genero;
        public string Tags { get; private set; } = tags;
        public string Diretor { get; private set; } = diretor;
        public string Estrelas { get; private set; } = estrelas;
        public string Estudio { get; private set; } = estudio;

        public string GetFormattedText()
        {
            string formattedText =
$@"**{Titulo}** - **{Audio}**

**HD** - __720p__
**SD** - __480p__
__[Os vídeos estão em ordem crescente, ou seja, de cima para baixo, tal como na descrição das resoluções.]__

**Sinopse:** __{Sinopse}__

**Nome Original:** __{TituloOriginal}__
**Título Alternativo:** __{TituloAlternativo}__
**Data de lançamento:** __{DataLancamento}__
**Franquia:** __{Franquia}__
**Países de Origem:** __{PaisOrigem}__
**Idioma Original:** __{IdiomaOriginal}__
**Anime:** {Anime}
**Autores:** {Autores}
**Gênero:** {Genero}
**Tags:** {Tags}
**Diretor:** {Diretor}
**Estrelas:** {Estrelas}
**Estúdio:** {Estudio}
";
            return formattedText;
        }
    }
}