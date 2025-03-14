using Aniflix.Models;
using Aniflix.Functions;

namespace Aniflix.Presenters
{
    public class BreakOutFilmesPresenter
    {
        public static void Registrar(BreakOutFilmesModels item)
        {

            var geral = GlobalVars.context.Breakout_Filmes
                .Where(x => x.Codigo == item.Codigo)
                .FirstOrDefault();

            if (geral == null)
            {
                GlobalVars.context.Breakout_Filmes.Add(item);
                GlobalVars.context.SaveChanges();
                MessageBox.Show(item.Titulo + " cadastrado com sucesso!", "BreakOut - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " já está cadastrado!", "BreakOut - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Atualizar(BreakOutFilmesModels item)
        {

            var itemExistente = GlobalVars.context.Breakout_Filmes
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
                MessageBox.Show(item.Titulo + " atualizado com sucesso!", "BreakOut - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(item.Titulo + " não encontrado nos registros!", "BreakOut - Filmes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static BreakOutFilmesModels GetFirstRow()
        {
            return GlobalVars.context.Breakout_Filmes
                .OrderBy(x => x.Id)
                .FirstOrDefault();

        }

        public static BreakOutFilmesModels GetNearRow(int id)
        {
            try
            {
                return GlobalVars.context.Breakout_Filmes
                    .Where(x => x.Id > id)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();

            }
            catch
            {
                return null!;
            }
        }

        public static BreakOutFilmesModels GetPriorRow(int id)
        {
            try
            {
                if (id == 0)
                {
                    return null!;
                }

                return GlobalVars.context.Breakout_Filmes
                    .Where(x => x.Id < id)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();
            }
            catch
            {
                return null!;
            }
        }


        public static bool Existe(int id)
        {
            return GlobalVars.context.Breakout_Filmes.Any(x => x.Id == id);
        }
    }
}