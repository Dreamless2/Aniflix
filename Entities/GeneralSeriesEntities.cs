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

namespace Aniflix.Entities
{
    public class GeneralSeriesEntities(string titulo, string audio, string sinopse = null!, string tituloOriginal = null!,
               string dataLancamento = null!, string tituloAlternativo = null!, string paisOrigem = null!, string idiomaOriginal = null!, string serie = null!,
               string franquia = null!, string autores = null!, string criadores = null!, string obraOriginal = null!, string genero = null!, string tags = null!,
               string diretor = null!, string estrelas = null!, string estudio = null!)
    {
        public string Titulo { get; private set; } = titulo;
        public string Audio { get; private set; } = audio;
        public string Sinopse { get; private set; } = sinopse;
        public string TituloOriginal { get; private set; } = tituloOriginal;
        public string DataLancamento { get; private set; } = dataLancamento;
        public string TituloAlternativo { get; private set; } = tituloAlternativo;
        public string PaisOrigem { get; private set; } = paisOrigem;
        public string IdiomaOriginal { get; private set; } = idiomaOriginal;
        public string Serie { get; private set; } = serie;
        public string Franquia { get; private set; } = franquia;
        public string Autores { get; private set; } = autores;
        public string Criadores { get; private set; } = criadores;
        public string ObraOriginal { get; private set; } = obraOriginal;
        public string Genero { get; private set; } = genero;
        public string Tags { get; private set; } = tags;
        public string Diretor { get; private set; } = diretor;
        public string Estrelas { get; private set; } = estrelas;
        public string Estudio { get; private set; } = estudio;

        public string GetFormattedText()
        {
            string formattedText =
$@"**{Titulo} - {Audio}**

**Sinopse:** __{Sinopse}__

**Nome Original:** __{TituloOriginal}__
**Título Alternativo:** __{TituloAlternativo}__
**Data de lançamento:** __{DataLancamento}__
**Países de Origem:** __{PaisOrigem}__
**Idioma Original:** __{IdiomaOriginal}__
**Série:** {Serie}
**Franquia:** {Franquia}
**Autores:** {Autores}
**Criadores:** {Criadores}
**Obra Original:** {ObraOriginal}
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