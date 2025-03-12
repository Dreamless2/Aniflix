using Sunny.UI;
using Aniflix.Models;
using Aniflix.Services;
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

        private void FilmesView_Load(object sender, EventArgs e)
        {
            //GlobalFunctions.ApplyTheme(this);
        }

        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            var filmesService = new FilmesServices();

            var codigo = CodigoText.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                UIMessageBox.ShowError("Informe o código do filme.");
                CodigoText.Focus();
                return;
            }
            else
            {
                await filmesService.GivenData(CodigoText.Text.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, TagsText, GeneroText, DiretorText, EstrelasText, EstudioText);
            }
        }
    }
}