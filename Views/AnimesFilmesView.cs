using System;
using Sunny.UI;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Aniflix.Entities;
using Aniflix.Functions;
using Aniflix.Models;
using Aniflix.Presenters;
using Aniflix.Services;

namespace Aniflix.Views
{
    public partial class AnimesFilmesView : UIForm
    {
        public AnimesFilmesView()
        {
            InitializeComponent();
        }

        #region "ChangeData"
        private void ChangeData()
        {

            var entities = new BaseFilmesEntities(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                filme: FilmeText.Text,
                franquia: FranquiaText.Text,
                genero: GeneroText.Text,
                tags: TagsText.Text,
                diretor: DiretorText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text
            );
            ResumoText.Text = entities.GetFormattedText();
        }
        #endregion

        #region "FillData"
        private void FillData()
        {
            var filmes = AnimesFilmesPresenter.GetFirstRow();

            if (filmes != null)
            {
                GlobalVars.currentId = filmes.Id;
                CodigoText.Text = filmes.Codigo;
                TituloText.Text = filmes.Titulo;
                AudioBox.SelectedItem = filmes.Audio;
                SinopseText.Text = filmes.Sinopse;
                TituloOriginalText.Text = filmes.Titulo_Original;
                DataLancamentoText.Text = filmes.Data_Lancamento;
                TituloAlternativoText.Text = filmes.Titulo_Alternativo;
                FilmeText.Text = filmes.Filme;
                FranquiaText.Text = filmes.Franquia;
                GeneroText.Text = filmes.Genero;
                TagsText.Text = filmes.Tags;
                DiretorText.Text = filmes.Diretor;
                EstrelasText.Text = filmes.Estrelas;
                EstudioText.Text = filmes.Estudio;
            }
            ;
        }
        #endregion

        #region "Load"
        private void FilmesView_Load(object sender, EventArgs e)
        {
            ChangeData();
            CodigoText.Focus();

            try
            {
                bool findData = AnimesFilmesPresenter.Existe(1);

                if (findData)
                {
                    FillData();
                }
                else
                {
                    MessageBox.Show("Nenhum filme cadastrado.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Leave"
        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            var services = new AnimesFilmesServices();
            if (!int.TryParse(CodigoText.Text, out var codigo) || codigo <= 0)
            {
                UIMessageBox.ShowError("Informe um código válido.", false, 1000);
                CodigoText.Focus();
            }
            else
            {
                await services.GivenData(codigo.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, FilmeText, TagsText, GeneroText, DiretorText, EstrelasText, EstudioText);
            }
        }
        #endregion

        #region "KeyPress"
        private void CodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region "TextChanged"
        private void TituloText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void AudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void SinopseText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TituloOriginalText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void DataLancamentoText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TituloAlternativoText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TagsText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void FilmeText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void FranquiaText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void GeneroText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void DiretorText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void EstrelasText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void EstudioText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        #endregion

        #region "CopiarButton"
        private void CopiarButton_Click(object sender, EventArgs e)
        {
            ResumoText.SelectAll();
            ResumoText.Copy();
        }
        #endregion

        #region "InserirNovoButton"
        private void InserirNovoButton_Click(object sender, EventArgs e)
        {
            var filmes = new AnimesFilmesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Filme = FilmeText.Text,
                Franquia = FranquiaText.Text,
                Genero = GeneroText.Text,
                Tags = TagsText.Text,
                Diretor = DiretorText.Text,
                Estrelas = EstrelasText.Text,
                Estudio = EstudioText.Text
            };

            if (!string.IsNullOrEmpty(filmes.Codigo))
            {
                AnimesFilmesPresenter.Registrar(filmes);
            }
            else
            {
                MessageBox.Show("Por favor, insira o código do filme.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "EditarButton"
        private void EditarButton_Click(object sender, EventArgs e)
        {
            var item = new AnimesFilmesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Filme = FilmeText.Text,
                Franquia = FranquiaText.Text,
                Genero = GeneroText.Text,
                Tags = TagsText.Text,
                Diretor = DiretorText.Text,
                Estrelas = EstrelasText.Text,
                Estudio = EstudioText.Text
            };

            if (!GlobalVars.editando)
            {
                GlobalVars.editando = true;
                EditarButton.Text = "Cancelar";
                GlobalFunctions.UndoReadOnly(this);
            }
            else if (EditarButton.Text == "Cancelar")
            {
                var cancelar = MessageBox.Show($"Cancelar a edição do filme {item.Titulo} ?", "Filmes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cancelar == DialogResult.Yes)
                {
                    GlobalVars.editando = false;
                    GlobalFunctions.DoReadOnly(this);
                    EditarButton.Text = "Editar";
                }
                else
                {
                    EditarButton.Text = "Salvar";
                }
            }
            else if (EditarButton.Text == "Salvar")
            {
                var atualizar = MessageBox.Show($"Atualizar as informações sobre o filme {item.Titulo} ?", "Filmes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (atualizar == DialogResult.Yes)
                {
                    AnimesFilmesPresenter.Atualizar(item);
                }

                GlobalFunctions.DoReadOnly(this);
                EditarButton.Text = "Editar";
                GlobalVars.editando = false;
            }
        }
        #endregion

        #region "AnteriorButton"
        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            var item = AnimesFilmesPresenter.GetPriorRow(GlobalVars.currentId);

            if (item != null)
            {
                GlobalVars.currentId = item.Id;
                CodigoText.Text = item.Codigo;
                TituloText.Text = item.Titulo;
                AudioBox.SelectedItem = item.Audio;
                SinopseText.Text = item.Sinopse;
                TituloOriginalText.Text = item.Titulo_Original;
                DataLancamentoText.Text = item.Data_Lancamento;
                TituloAlternativoText.Text = item.Titulo_Alternativo;
                FilmeText.Text = item.Filme;
                FranquiaText.Text = item.Franquia;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao início da lista.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "ProximoButton"
        private void ProximoButton_Click(object sender, EventArgs e)
        {

            var item = AnimesFilmesPresenter.GetNearRow(GlobalVars.currentId);

            if (item != null)
            {
                GlobalVars.currentId = item.Id;
                CodigoText.Text = item.Codigo;
                TituloText.Text = item.Titulo;
                AudioBox.SelectedItem = item.Audio;
                SinopseText.Text = item.Sinopse;
                TituloOriginalText.Text = item.Titulo_Original;
                DataLancamentoText.Text = item.Data_Lancamento;
                TituloAlternativoText.Text = item.Titulo_Alternativo;
                FilmeText.Text = item.Filme;
                FranquiaText.Text = item.Franquia;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao fim da lista.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}