using Sunny.UI;
using Aniflix.Models;
using Aniflix.Services;
using Aniflix.Entities;
using Aniflix.Functions;
using FontAwesome.Sharp.Material;

namespace Aniflix.Views
{
    public partial class FilmesView : UIForm
    {
        public FilmesView()
        {
            InitializeComponent();
        }



        #region "ChangeData"
        private void ChangeData()
        {

            var entities = new FilmesEntities(
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
                mcu: FaseMCUText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text

            );

            ResumoText.Text = entities.GetFormattedText();
        }

        #endregion



        private void FilmesView_Load(object sender, EventArgs e)
        {
            //GlobalFunctions.ApplyTheme(this);
        }

        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            var services = new FilmesServices();
            if (!int.TryParse(CodigoText.Text, out var codigo) || codigo <= 0)
            {
                UIMessageBox.ShowError("Informe um código de filme válido.");
                CodigoText.Focus();
                return;
            }
            else
            {
                await services.GivenData(codigo.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, FilmeText, TagsText, GeneroText, DiretorText, EstrelasText, EstudioText);
            }
        }

        private void TituloText_TextChanged(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void AudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}