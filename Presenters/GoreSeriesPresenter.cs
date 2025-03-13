using System.Linq;
using WatchFlix.Models;
using WatchFlix.Globals;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WatchFlix.Presenter
{
    public class GoreSeriesPresenter
    {
        public static void Registrar(GoreSeriesModels item)
        {
            var geral = GlobalVars.context.Gore_Series
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Gore_Series.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "Gore - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "Gore - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(GoreSeriesModels item)
        {
            var itemExistente = GlobalVars.context.Gore_Series
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
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "Gore - Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "Gore - Séries", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static GoreSeriesModels GetFirstRow()
        {
            return GlobalVars.context.Gore_Series
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static GoreSeriesModels GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Gore_Series
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static GoreSeriesModels GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.Gore_Series
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
            return GlobalVars.context.Gore_Series.Any(x => x.Id == id);
        }
    }
}

