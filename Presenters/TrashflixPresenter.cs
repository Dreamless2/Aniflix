using Aniflix.Models;

namespace Aniflix.Presenters
{
    public class TrashflixPresenter
    {
        public static void Registrar(TrashflixModels item)
        {

            var geral = GlobalVars.context.Trashflix
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Trashflix.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "Trashflix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "Trashflix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(TrashflixModels item)
        {

            var itemExistente = GlobalVars.context.Trashflix
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
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "Trashflix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "Trashflix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static TrashflixModels GetFirstRow()
        {
            return GlobalVars.context.Trashflix
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public static TrashflixModels GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Trashflix
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        public static TrashflixModels GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                return GlobalVars.context.Trashflix
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
            return GlobalVars.context.Trashflix.Any(x => x.Id == id);
        }
    }
}
