﻿#region "Copyright"
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
    public class AnimesFilmesPresenter
    {
        public static void Registrar(AnimesFilmesModels item)
        {

            var geral = GlobalVars.context.Animes_Filmes
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Animes_Filmes.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "Animes - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "Animes - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(AnimesFilmesModels item)
        {

            var itemExistente = GlobalVars.context.Animes_Filmes
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
                itemExistente.Filme = item.Filme;
                itemExistente.Franquia = item.Franquia;
                itemExistente.Genero = item.Genero;
                itemExistente.Tags = item.Tags;
                itemExistente.Diretor = item.Diretor;
                itemExistente.Estrelas = item.Estrelas;
                itemExistente.Estudio = item.Estudio;
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "Animes - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "Animes - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static AnimesFilmesModels? GetFirstRow()
        {
            return GlobalVars.context.Animes_Filmes
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static AnimesFilmesModels? GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Animes_Filmes
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static AnimesFilmesModels? GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.Animes_Filmes
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
            return GlobalVars.context.Animes_Filmes.Any(x => x.Id == id);
        }
    }
}
