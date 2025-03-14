﻿namespace Aniflix.Entities
{
    public class BaseFilmesEntities(string titulo, string franquia, string sinopse = null!, string tituloOriginal = null!,
               string dataLancamento = null!, string tituloAlternativo = null!, string filme = null!, string genero = null!, string tags = null!,
               string diretor = null!, string mcu = null!, string estrelas = null!, string estudio = null!, string audio = null!)
    {
        public string Titulo { get; private set; } = titulo;
        public string Audio { get; private set; } = audio;
        public string Sinopse { get; private set; } = sinopse;
        public string TituloOriginal { get; private set; } = tituloOriginal;
        public string DataLancamento { get; private set; } = dataLancamento;
        public string TituloAlternativo { get; private set; } = tituloAlternativo;
        public string Filme { get; private set; } = filme;
        public string Franquia { get; private set; } = franquia;
        public string Genero { get; private set; } = genero;
        public string Tags { get; private set; } = tags;
        public string Diretor { get; private set; } = diretor;
        public string MCU { get; private set; } = mcu;
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

**Título Original:** __{TituloOriginal}__
**Título Alternativo:** __{TituloAlternativo}__
**Data de lançamento:** __{DataLancamento}__
**Filme:** {Filme}
**Franquia:** {Franquia}
**Gênero:** {Genero}
**Tags:** {Tags}
**Diretor:** {Diretor}
**Fase MCU:** {MCU}
**Estrelas:** {Estrelas}
**Estúdio:** {Estudio}
";
            return formattedText;
        }
    }
}

