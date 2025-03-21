﻿#region "Copyright"
/***********************************************************************************
* Copyright (C) 2025  Tiago.NET
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
**********************************************************************************/
#endregion

using Sunny.UI;
using System.Reflection;
using System.Diagnostics;

namespace Aniflix.Views
{
    public partial class SobreView : UIForm
    {

        #region "Constructor"
        public SobreView()
        {
            InitializeComponent();
        }
        #endregion

        #region "Form Load"
        private void SobreView_Load(object sender, EventArgs e)
        {
            LinkTMDB.Links.Add(0, LinkTMDB.Text.Length, "https://www.themoviedb.org/");
            LinkLicenseSite.Links.Add(0, LinkLicenseSite.Text.Length, "https://www.gnu.org/licenses/gpl-3.0.html");
            LinkTMDBLib.Links.Add(0, LinkTMDBLib.Text.Length, "https://github.com/jellyfin/TMDbLib");
            LinkSunnyUI.Links.Add(0, LinkSunnyUI.Text.Length, "https://github.com/SunnyUI/SunnyUI");
            LinkDEEPLSite.Links.Add(0, LinkDEEPLSite.Text.Length, "https://github.com/DeepLcom/deepl-dotnet");
            var sunny = Assembly.Load("SunnyUi");
            var tmddlib = Assembly.Load("TMDbLib");
            var deeplNet = Assembly.Load("DeepL.Net");

            SunnyVersion.Text = "SunnyUI " + sunny.GetName().Version!.ToString();
            TMDBLibVersion.Text = "TMDbLib " + tmddlib.GetName().Version!.ToString();
            DEEPLVersion.Text = "DeepL.Net " + deeplNet.GetName().Version!.ToString();
        }
        #endregion

        #region "PictureBox Click"
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
        private void DEEPLBox_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/DeepLcom/deepl-dotnet";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        #endregion

        #region "Mouse Enter"
        private void LogoBox_MouseEnter(object sender, EventArgs e)
        {
            LogoBox.Cursor = Cursors.Hand;
        }
        private void LicenseBox_MouseEnter(object sender, EventArgs e)
        {
            LicenseBox.Cursor = Cursors.Hand;
        }
        private void SunnyBox_MouseEnter(object sender, EventArgs e)
        {
            SunnyBox.Cursor = Cursors.Hand;
        }

        private void DEEPLBox_MouseEnter(object sender, EventArgs e)
        {
            DEEPLBox.Cursor = Cursors.Hand;
        }
        #endregion

        #region "Link Click"
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
        private void LinkDEEPLSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        #endregion

        #region "Button Click"
        private void FecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}