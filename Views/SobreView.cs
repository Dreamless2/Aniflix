using Sunny.UI;
using System.Diagnostics;

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
            LinkSite.Links.Add(0, 12, "https://www.themoviedb.org/");
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.themoviedb.org/");
        }

        private void LinkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkData = (string)e.Link!.LinkData!;
            if (linkData != null)
            {
                Process.Start(linkData);
            }
        }
    }
}
