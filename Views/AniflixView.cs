#region "Copyright"
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
using Aniflix.Functions;
using FontAwesome.Sharp.Material;

namespace Aniflix.Views
{
    public partial class AniflixView : UIForm
    {

        #region "Constructor"
        public AniflixView()
        {
            InitializeComponent();
            GlobalVars.random = new Random();
            GlobalVars.leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            MenuPanel.Controls.Add(GlobalVars.leftBorderBtn);
            Text = string.Empty;
            DoubleBuffered = true;
        }
        #endregion

        #region "Activate Button"
        private void ActivateButton(object btnSender)
        {
            var (backgroundColor, accentColor) = GlobalFunctions.SelectThemeColors();
            var color = Color.FromArgb(37, 36, 81);

            if (btnSender != null)
            {
                if (GlobalVars.currentBtn != (MaterialButton)btnSender)
                {
                    DisableButton();

                    GlobalVars.currentBtn = (MaterialButton)btnSender;
                    GlobalVars.currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    GlobalVars.currentBtn.ForeColor = accentColor;
                    GlobalVars.currentBtn.IconColor = accentColor;
                    GlobalVars.currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    GlobalVars.currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                    TitleBarPanel.BackColor = backgroundColor;
                    TitleBarPanel.FillColor = backgroundColor;
                    TitleBarPanel.TitleColor = backgroundColor;
                    TitleBarPanel.TitleForeColor = accentColor;
                    TitleBarPanel.RectColor = backgroundColor;

                    LogoPanel.BackColor = color;
                    LogoPanel.FillColor = color;

                    MenuPanel.BackColor = color;
                    MenuPanel.FillColor = color;

                    GlobalVars.leftBorderBtn!.BackColor = accentColor;
                    GlobalVars.leftBorderBtn.Location = new Point(0, GlobalVars.currentBtn.Location.Y);
                    GlobalVars.leftBorderBtn.Visible = true;
                    GlobalVars.leftBorderBtn.BringToFront();

                    ThemeColor.PrimaryColor = backgroundColor;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(backgroundColor, -0.55);

                    CurrentChildFormBox.IconChar = GlobalVars.currentBtn.IconChar;
                    CurrentChildFormBox.IconColor = accentColor;
                    CurrentChildFormBox.ForeColor = accentColor;

                    TitleChildFormLabel.ForeColor = accentColor;

                    this.TitleColor = accentColor;
                }
            }
        }
        #endregion

        #region "Disable Button"

        private static void DisableButton()
        {
            if (GlobalVars.currentBtn != null)
            {
                GlobalVars.currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                GlobalVars.currentBtn.ForeColor = Color.Gainsboro;
                GlobalVars.currentBtn.IconColor = Color.Gainsboro;
                GlobalVars.currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                GlobalVars.currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                GlobalVars.currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        #endregion

        #region "Reset"
        private void Reset()
        {
            DisableButton();
            GlobalVars.leftBorderBtn!.Visible = false;
            GlobalVars.currentBtn = null;
            TitleBarPanel.BackColor = Color.Transparent;
            MenuPanel.BackColor = Color.Transparent;
            TitleBarPanel.Text = "Home";
            TitleChildFormLabel.Text = "Home";
            CurrentChildFormBox.IconChar = FontAwesome.Sharp.MaterialIcons.Home;
        }
        #endregion

        #region "Open Child Form"
        private void OpenChildForm(UIForm childForm, object btnSender)
        {
            GlobalVars.currentChildForm?.Close();
            ActivateButton(btnSender);
            GlobalVars.currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.TitleColor = Color.FromArgb(60, 101, 83);
            childForm.TitleForeColor = Color.FromArgb(253, 228, 110);
            childForm.RectColor = Color.FromArgb(0, 156, 82);
            childForm.ShowRect = false;
            childForm.BringToFront();
            childForm.Show();
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            TitleChildFormLabel.Text = childForm.Text;
            TitleBarPanel.Text = childForm.Text;
        }
        #endregion

        #region "Buttons Click"
        private void FilmesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FilmesView(), sender);
        }

        private void SeriesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SeriesView(), sender);
        }

        private void AnimesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AnimesView(), sender);
        }

        private void AnimesFilmesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AnimesFilmesView(), sender);
        }

        private void GoreFilmesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new GoreFilmesView(), sender);
        }

        private void GoreSeriesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new GoreSeriesView(), sender);
        }

        private void BreakOutFilmesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new BreakOutFilmesView(), sender);
        }

        private void BreakOutSeriesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new BreakOutSeriesView(), sender);
        }

        private void TrashflixButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new TrashflixView(), sender);
        }
        private void SobreButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var sobre = new SobreView();
            sobre.ShowDialog();
        }
        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogoBox_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion
    }
}