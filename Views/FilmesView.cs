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
            var services = new FilmesServices();
            if (!int.TryParse(CodigoText.Text, out var codigo) || codigo <= 0)
            {
                UIMessageBox.ShowError("Informe um código de filme válido.");
                CodigoText.Focus();
                return;
            }
            else
            {
                await services.GivenData(codigo.ToString(), TituloText, SinopseText, TituloOriginalText, DataLancamentoText, TituloAlternativoText, TagsText, GeneroText, DiretorText, EstrelasText, EstudioText);
            }
        }
    }
}