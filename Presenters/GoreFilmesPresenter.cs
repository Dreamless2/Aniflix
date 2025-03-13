using System.Linq;
using WatchFlix.Models;
using WatchFlix.Globals;
using System.Windows.Forms;

namespace WatchFlix.Presenter
{
    public static class GoreFilmesPresenter
    {
        public static void Registrar(GoreFilmesModels item)
        {
            var geral = GlobalVars.context.Gore_Filmes
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Gore_Filmes.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "Gore - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "Gore - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(GoreFilmesModels item)
        {

            var itemExistente = GlobalVars.context.Gore_Filmes
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
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "Gore - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "Gore - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static GoreFilmesModels GetFirstRow()
        {
            return GlobalVars.context.Gore_Filmes
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static GoreFilmesModels GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Gore_Filmes
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static GoreFilmesModels GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.Gore_Filmes
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
            return GlobalVars.context.Gore_Filmes.Any(x => x.Id == id);
        }
    }
}