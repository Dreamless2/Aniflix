using Sunny.UI;
using Sunny.UI.Win32;
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
            LinkSite.Links.Add(0, LinkSite.Text.Length, "https://www.themoviedb.org/");
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            var target =
            Process.Start(new ProcessStartInfo
            {
                FileName = target,
                UseShellExecute = true
            });
        }

        private void LinkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var target = e.Link!.LinkData! as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
            }
        }
    }
}
