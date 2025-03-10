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
            GlobalFunctions.LoadSvgFromUrlAsync("");
        }
    }
}
