using Sunny.UI;
using Aniflix.Services;
using Aniflix.Functions;
using FontAwesome.Sharp.Material;
using Aniflix.Models;

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

        private void CodigoText_Leave(object sender, EventArgs e)
        {
            var filmesService = new FilmesServices();
            var filmesModel = new FilmesModel();

            var codigo = int.Parse(CodigoText.Text);
            filmesService.GivenData(codigo, TituloText, SinopseText, TituloOriginalText, DataLancamentoText.Text, TagsText.Text, GeneroText.Text, DiretorText.Text, EstrelasText.Text, EstudioText.Text, TituloAlternativoText.Text);

        }
    }
}