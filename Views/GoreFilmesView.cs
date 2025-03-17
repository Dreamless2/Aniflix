using Sunny.UI;
using Aniflix.Models;
using Aniflix.Entities;
using Aniflix.Services;
using Aniflix.Functions;
using Aniflix.Presenters;

namespace Aniflix.Views
{
    public partial class GoreFilmesView : UIForm
    {
        public GoreFilmesView()
        {
            InitializeComponent();
        }

        private void ChangeData()
        {

            var item = new GeneralFilmesEntities(
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
            ResumoText.Text = item.GetFormattedText();
        }

        private void FillData()
        {
            var item = GoreFilmesPresenter.GetFirstRow();

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
            ;
        }

        private void GoreFilmesView_Load(object sender, EventArgs e)
        {
            ChangeData();
            CodigoText.Focus();

            try
            {
                bool findData = GoreFilmesPresenter.Existe(1);

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

        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            var services = new FilmesServices();
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

        private void CodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void DataLancamentoText_TextChanged(object sender, EventArgs e)
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

        private void SinopseText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TagsText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TituloAlternativoText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TituloOriginalText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void TituloText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void CopiarButton_Click(object sender, EventArgs e)
        {
            ResumoText.SelectAll();
            ResumoText.Copy();
        }

        private void InserirNovoButton_Click(object sender, EventArgs e)
        {
            var item = new GoreFilmesModels
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

            if (!string.IsNullOrEmpty(item.Codigo))
            {
                GoreFilmesPresenter.Registrar(item);
            }
            else
            {
                MessageBox.Show("Por favor, insira o código do filme.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            var item = new GoreFilmesModels
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
                    GoreFilmesPresenter.Atualizar(item);
                }

                GlobalFunctions.DoReadOnly(this);
                EditarButton.Text = "Editar";
                GlobalVars.editando = false;
            }
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            var item = GoreFilmesPresenter.GetPriorRow(GlobalVars.currentId);

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

        private void ProximoButton_Click(object sender, EventArgs e)
        {

            var item = GoreFilmesPresenter.GetNearRow(GlobalVars.currentId);

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
    }
}
