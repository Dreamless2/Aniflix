using System.Linq;
using WatchFlix.Models;
using WatchFlix.Globals;
using System.Windows.Forms;
using System.Collections.Generic;
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
            return GlobalVars.context.Breakout_Filmes.FirstOrDefault();
        }

        public static BreakOutFilmesModels ObterUltimo()
        {
            return GlobalVars.context.Breakout_Filmes.LastOrDefault();
        }

        public static BreakOutFilmesModels GetNearRow(string codigoAtual)
        {
            var proximo = GlobalVars.context.Breakout_Filmes
                .Where(x => string.Compare(x.Codigo, codigoAtual) > 0)
                .OrderBy(x => x.Codigo)
                .FirstOrDefault();

            return proximo;
        }
        public static BreakOutFilmesModels GetPriorRow(string codigoAtual)
        {
            var anterior = GlobalVars.context.Breakout_Filmes
                .Where(x => string.Compare(x.Codigo, codigoAtual) < 0)
                .OrderBy(x => x.Codigo)
                .FirstOrDefault();

            return anterior;
        }
        public static List<BreakOutFilmesModels> ObterTodos()
        {
            var listaFilmes = GlobalVars.context.Breakout_Filmes
                .OrderBy(x => x.Codigo)
                .ToList();

            return listaFilmes;
        }

        public static bool Existe(int id)
        {
            return GlobalVars.context.Breakout_Filmes.Any(x => x.Id == id);
        }
    }
}