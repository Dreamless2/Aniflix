using Sunny.UI;
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
            GlobalFunctions.ApplyTheme(this);
        }


    }
}