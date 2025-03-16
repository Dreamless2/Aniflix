using Sunny.UI;
using Aniflix.Entities;
using Aniflix.Services;

namespace Aniflix.Views
{
    public partial class SeriesView : UIForm
    {
        public SeriesView()
        {
            InitializeComponent();
        }



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
                estudio: EstudioText.Text,
                mcu: FaseMCUText.Text
            );
            ResumoText.Text = services.GetFormattedText();
        }
        #endregion

        #region "CodigoText"
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

        private void CodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void SeriesView_Load(object sender, EventArgs e)
        {
            ChangeData();
        }

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

        private void FaseMCUText_TextChanged(object sender, EventArgs e)
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

        private void CriadoresText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void DiretorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstrelasText_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneroText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstudioText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
