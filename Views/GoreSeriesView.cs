﻿using Sunny.UI;
using Aniflix.Models;
using Aniflix.Entities;
using Aniflix.Services;
using Aniflix.Functions;
using Aniflix.Presenters;

namespace Aniflix.Views
{
    public partial class GoreSeriesView : UIForm
    {
        public GoreSeriesView()
        {
            InitializeComponent();
        }

        #region "FillData"
        private void FillData()
        {
            var item = SeriesPresenter.GetFirstRow();

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
                SerieText.Text = item.Serie;
                FranquiaText.Text = item.Franquia;
                AutoresText.Text = item.Autores;
                CriadoresText.Text = item.Criadores;
                ObraOriginalText.Text = item.Obra_Original;
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

            var services = new BaseSeriesEntities(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                paisOrigem: PaisOrigemText.Text,
                idiomaOriginal: IdiomaOriginalText.Text,
                serie: SerieText.Text,
                autores: AutoresText.Text,
                criadores: CriadoresText.Text,
                obraOriginal: ObraOriginalText.Text,
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
        private void GoreSeriesView_Load(object sender, EventArgs e)
        {
            ChangeData();
            CodigoText.Focus();

            try
            {
                bool findData = FilmesPresenter.Existe(1);

                if (findData)
                {
                    FillData();
                }
                else
                {
                    MessageBox.Show("Nenhuma série cadastrada.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(CodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código da série.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodigoText.Focus();
            }
            else
            {
                var services = new SeriesServices();
                if (!int.TryParse(CodigoText.Text, out var codigo) || codigo <= 0)
                {
                    MessageBox.Show("Por favor, insira um código válido.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CodigoText.Focus();
                    return;
                }

                await services.GivenData(codigo.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, PaisOrigemText, IdiomaOriginalText, SerieText, CriadoresText, GeneroText, TagsText, EstrelasText, EstudioText);
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

        private void SerieText_TextChanged(object sender, EventArgs e)
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

        private void ObraOriginalText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void CriadoresText_TextChanged(object sender, EventArgs e)
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
            var item = new GoreSeriesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Pais_Origem = PaisOrigemText.Text,
                Idioma_Original = IdiomaOriginalText.Text,
                Serie = SerieText.Text,
                Franquia = FranquiaText.Text,
                Autores = AutoresText.Text,
                Criadores = CriadoresText.Text,
                Obra_Original = ObraOriginalText.Text,
                Genero = GeneroText.Text,
                Tags = TagsText.Text,
                Diretor = DiretorText.Text,
                Estrelas = EstrelasText.Text,
                Estudio = EstudioText.Text
            };

            if (!string.IsNullOrEmpty(item.Codigo))
            {
                GoreSeriesPresenter.Registrar(item);
            }
            else
            {
                MessageBox.Show("Por favor, insira o código da série.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "EditarButton"
        private void EditarButton_Click(object sender, EventArgs e)
        {
            var item = new GoreSeriesModels
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                Titulo_Original = TituloOriginalText.Text,
                Data_Lancamento = DataLancamentoText.Text,
                Titulo_Alternativo = TituloAlternativoText.Text,
                Pais_Origem = PaisOrigemText.Text,
                Idioma_Original = IdiomaOriginalText.Text,
                Serie = SerieText.Text,
                Franquia = FranquiaText.Text,
                Autores = AutoresText.Text,
                Criadores = CriadoresText.Text,
                Obra_Original = ObraOriginalText.Text,
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
                var cancelar = MessageBox.Show($"Cancelar a edição da série {item.Titulo} ?", "Séries", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                var atualizar = MessageBox.Show($"Atualizar as informações sobre a série {item.Titulo} ?", "Séries", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (atualizar == DialogResult.Yes)
                {
                    GoreSeriesPresenter.Atualizar(item);
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
            var item = GoreSeriesPresenter.GetPriorRow(GlobalVars.currentId);

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
                SerieText.Text = item.Serie;
                FranquiaText.Text = item.Franquia;
                AutoresText.Text = item.Autores;
                CriadoresText.Text = item.Criadores;
                ObraOriginalText.Text = item.Obra_Original;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao início da lista.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "ProximoButton"
        private void ProximoButton_Click(object sender, EventArgs e)
        {

            var item = GoreSeriesPresenter.GetNearRow(GlobalVars.currentId);

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
                PaisOrigemText.Text = item.Pais_Origem;
                IdiomaOriginalText.Text = item.Idioma_Original;
                SerieText.Text = item.Serie;
                FranquiaText.Text = item.Franquia;
                AutoresText.Text = item.Autores;
                CriadoresText.Text = item.Criadores;
                ObraOriginalText.Text = item.Obra_Original;
                GeneroText.Text = item.Genero;
                TagsText.Text = item.Tags;
                DiretorText.Text = item.Diretor;
                EstrelasText.Text = item.Estrelas;
                EstudioText.Text = item.Estudio;
            }
            else
            {
                MessageBox.Show("Sem mais registros. Chegou ao fim da lista.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
