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
        private void SobreView_Load(object sender, EventArgs e)
        {
            LinkTMDB.Links.Add(0, LinkTMDB.Text.Length, "https://www.themoviedb.org/");
            LinkLicenseSite.Links.Add(0, LinkLicenseSite.Text.Length, "https://www.gnu.org/licenses/gpl-3.0.html");
            LinkTMDBLib.Links.Add(0, LinkTMDBLib.Text.Length, "https://github.com/jellyfin/TMDbLib");
            LinkSunnyUI.Links.Add(0, LinkSunnyUI.Text.Length, "https://github.com/SunnyUI/SunnyUI");
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            var url = "https://www.themoviedb.org/";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void LicenseBox_Click(object sender, EventArgs e)
        {
            var url = "https://www.gnu.org/licenses/gpl-3.0.html";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true

            });
        }
        private void SunnyBox_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/yhuse/SunnyUI";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true

            });
        }


        private void FecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }






        private void LogoBox_MouseEnter(object sender, EventArgs e)
        {
            LogoBox.Cursor = Cursors.Hand;
        }

        private void LicenseBox_MouseEnter(object sender, EventArgs e)
        {
            LicenseBox.Cursor = Cursors.Hand;
        }











        private void LinkTMDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void LinkTMDBLib_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void LinkSunnyUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void LinkLicenseSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void SunnyBox_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}