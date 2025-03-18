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

using Sunny.UI;
using Aniflix.Models;
using Aniflix.Entities;
using Aniflix.Services;
using Aniflix.Functions;
using Aniflix.Presenters;

namespace Aniflix.Views
{
    public partial class AnimesView : UIForm
    {
        #region "Constructor"
        public AnimesView()
        {
            InitializeComponent();
        }
        #endregion

        #region "FillData"
        private void FillData()
        {
            var item = AnimesPresenter.GetFirstRow();

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
                FranquiaText.Text = item.Franquia;
                AnimeText.Text = item.Anime;
                PaisOrigemText.Text = item.Pais_Origem;
                IdiomaOriginalText.Text = item.Idioma_Original;
                AutoresText.Text = item.Autores;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            ;
        }
        #endregion

        #region "ChangeData"
        private void ChangeData()
        {

            var services = new BaseAnimesEntities(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                franquia: FranquiaText.Text,
                paisOrigem: PaisOrigemText.Text,
                idiomaOriginal: IdiomaOriginalText.Text,
                anime: AnimeText.Text,
                autores: AutoresText.Text,
                genero: GeneroText.Text,
                tags: TagsText.Text,
                diretor: DiretorText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text

            );
            ResumoText.Text = services.GetFormattedText();
        }
        #endregion

        #region "Load"
        private void AnimesView_Load(object sender, EventArgs e)
        {
            ChangeData();
            CodigoText.Focus();

            try
            {
                bool findData = AnimesPresenter.Existe(1);

                if (findData)
                {
                    FillData();
                }
                else
                {
                    MessageBox.Show("Nenhum anime cadastrado.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "FormClosing"
        private void AnimesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVars.isClosing = true;
        }
        #endregion

        #region "Leave"
        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            if (GlobalVars.isClosing)
            {
                return;
            }

            if (string.IsNullOrEmpty(CodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do anime.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodigoText.Focus();
            }
            else
            {
                var services = new AnimesServices();
                if (!int.TryParse(CodigoText.Text, out var codigo) || codigo <= 0)
                {
                    MessageBox.Show("Por favor, insira um código válido.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CodigoText.Focus();
                    return;
                }
                await services.GivenData(codigo.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, PaisOrigemText, IdiomaOriginalText, AnimeText, GeneroText, TagsText, EstrelasText, EstudioText);
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

        private void PaisOrigemText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void IdiomaOriginalText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void AnimeText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }
        private void FranquiaText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void AutoresText_TextChanged(object sender, EventArgs e)
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

        private void GeneroText_TextChanged(object sender, EventArgs e)
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
            var item = new AnimesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Franquia = FranquiaText.Text,
                Pais_Origem = PaisOrigemText.Text,
                Idioma_Original = IdiomaOriginalText.Text,
                Anime = AnimeText.Text,
                Autores = AutoresText.Text,
                Genero = GeneroText.Text,
                Tags = TagsText.Text,
                Diretor = DiretorText.Text,
                Estrelas = EstrelasText.Text,
                Estudio = EstudioText.Text
            };

            if (!string.IsNullOrEmpty(item.Codigo))
            {
                AnimesPresenter.Registrar(item);
            }
            else
            {
                MessageBox.Show("Por favor, insira o código da série.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "EditarButton"
        private void EditarButton_Click(object sender, EventArgs e)
        {
            var item = new AnimesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Franquia = FranquiaText.Text,
                Pais_Origem = PaisOrigemText.Text,
                Idioma_Original = IdiomaOriginalText.Text,
                Anime = AnimeText.Text,
                Autores = AutoresText.Text,
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
                var cancelar = MessageBox.Show($"Cancelar a edição da série {item.Titulo} ?", "Animes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                var atualizar = MessageBox.Show($"Atualizar as informações sobre a série {item.Titulo} ?", "Animes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (atualizar == DialogResult.Yes)
                {
                    AnimesPresenter.Atualizar(item);
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
            var item = AnimesPresenter.GetPriorRow(GlobalVars.currentId);

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
                FranquiaText.Text = item.Franquia;
                PaisOrigemText.Text = item.Pais_Origem;
                IdiomaOriginalText.Text = item.Idioma_Original;
                AnimeText.Text = item.Anime;
                AutoresText.Text = item.Autores;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao início da lista.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "ProximoButton"
        private void ProximoButton_Click(object sender, EventArgs e)
        {

            var item = AnimesPresenter.GetNearRow(GlobalVars.currentId);

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
                FranquiaText.Text = item.Franquia;
                PaisOrigemText.Text = item.Pais_Origem;
                IdiomaOriginalText.Text = item.Idioma_Original;
                AnimeText.Text = item.Anime;
                AutoresText.Text = item.Autores;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao fim da lista.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
