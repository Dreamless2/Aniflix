using System.Linq;
using Aniflix.Models;
using WatchFlix.Models;
using WatchFlix.Globals;
using System.Windows.Forms;
using System.Collections.Generic;
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
                itemExistente.Autores = item.Autores;
                itemExistente.Criadores = item.Criadores;
                itemExistente.Obra_Original = item.Obra_Original;
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

        public static BreakOutSeriesModels GetFirstRow()
        {
            return GlobalVars.context.BreakOut_Series
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static BreakOutSeriesModels GetNearRow(int id)
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

        public static BreakOutSeriesModels GetPriorRow(int id)
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

