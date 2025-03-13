using Aniflix.Models;
using Aniflix.Functions;

namespace Aniflix.Presenters
{
    public class AnimesPresenter
    {
        public static void Registrar(AnimesModels item)
        {
            var geral = GlobalVars.context.Animes
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Animes.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(AnimesModels item)
        {

            var itemExistente = GlobalVars.context.Animes
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
                itemExistente.Franquia = item.Franquia;
                itemExistente.Pais_Origem = item.Pais_Origem;
                itemExistente.Idioma_Original = item.Idioma_Original;
                itemExistente.Anime = item.Anime;
                itemExistente.Autores = item.Autores;
                itemExistente.Genero = item.Genero;
                itemExistente.Tags = item.Tags;
                itemExistente.Diretor = item.Diretor;
                itemExistente.Estrelas = item.Estrelas;
                itemExistente.Estudio = item.Estudio;
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static AnimesModels GetFirstRow()
        {
            return GlobalVars.context.Animes
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static AnimesModels GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Animes
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static AnimesModels GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.Animes
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
            return GlobalVars.context.Animes.Any(x => x.Id == id);
        }
    }
}
