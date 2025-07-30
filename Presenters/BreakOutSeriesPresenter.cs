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
using Aniflix.Functions;

namespace Aniflix.Presenters
{
    public class BreakOutSeriesPresenter
    {
        public static void Registrar(BreakOutSeriesModels item)
        {
            var geral = GlobalVars.context.BreakOut_Series
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.BreakOut_Series.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "BreakOut - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "BreakOut - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(BreakOutSeriesModels item)
        {
            var itemExistente = GlobalVars.context.BreakOut_Series
                .Where(x => x.Codigo == item.Codigo)
                .SingleOrDefault();

            if (itemExistente != null)
            {
                itemExistente.Titulo = item.Titulo;
                itemExistente.Audio = item.Audio;
                itemExistente.Sinopse = item.Sinopse;
                itemExistente.Titulo_Original = item.Titulo_Original;
                itemExistente.Data_Lancamento = item.Data_Lancamento;
                itemExistente.Titulo_Alternativo = item.Titulo_Alternativo;
                itemExistente.Pais_Origem = item.Pais_Origem;
                itemExistente.Idioma_Original = item.Idioma_Original;
                itemExistente.Serie = item.Serie;
                itemExistente.Franquia = item.Franquia;
                itemExistente.Autores = item.Autores;
                itemExistente.Criadores = item.Criadores;
                itemExistente.Genero = item.Genero;
                itemExistente.Tags = item.Tags;
                itemExistente.Diretor = item.Diretor;
                itemExistente.Estrelas = item.Estrelas;
                itemExistente.Estudio = item.Estudio;
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "BreakOut - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "BreakOut - Séries", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static BreakOutSeriesModels? GetFirstRow()
        {
            return GlobalVars.context.BreakOut_Series
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static BreakOutSeriesModels? GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.BreakOut_Series
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static BreakOutSeriesModels? GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.BreakOut_Series
                    .Where(x => x.Id < id)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public static bool Existe(int id)
        {
            return GlobalVars.context.BreakOut_Series.Any(x => x.Id == id);
        }
    }
}

