using System;
using Sunny.UI;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Functions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Views
{
    public partial class SobreView : UIForm
    {
        public SobreView()
        {
            InitializeComponent();
        }

        private void uiLedLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SobreView_Load(object sender, EventArgs e)
        {
            GlobalFunctions.LoadSvgFromUrlAsync("https://www.themoviedb.org/assets/2/v4/logos/v2/blue_square_1-5bdc75aaebeb75dc7ae79426ddd9be3b2be1e342510f8202baf6bffa71d7f5c4.svg", WebCanvas);
        }
    }
}
