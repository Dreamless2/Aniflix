using Sunny.UI;
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

        private void CodigoText_Leave(object sender, EventArgs e)
        {
            var filmesService = new FilmesServices();

        }
    }
}