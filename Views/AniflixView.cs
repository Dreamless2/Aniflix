using Sunny.UI;
using System.Net;
using Aniflix.Functions;
using FontAwesome.Sharp.Material;
using SharpVectors.Renderers.Forms;

namespace Aniflix.Views
{
    public partial class AniflixView : UIForm
    {


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

                    this.TitleColor = backgroundColor;
                }
            }
        }
        private void DisableButton()
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
        private void Reset()
        {
            DisableButton();
            GlobalVars.leftBorderBtn!.Visible = false;
            GlobalVars.currentBtn = null;
            TitleBarPanel.BackColor = Color.FromArgb(0, 150, 136);
            MenuPanel.BackColor = Color.FromArgb(39, 39, 58);
            TitleChildFormLabel.Text = "Home";
            CurrentChildFormBox.IconChar = FontAwesome.Sharp.MaterialIcons.Home;
        }
        private void OpenChildForm(UIForm childForm, object btnSender)
        {

            GlobalVars.currentChildForm?.Close();
            GlobalVars.currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.TitleColor = Color.FromArgb(255, 211, 50);
            childForm.TitleForeColor = Color.FromArgb(0, 156, 82);
            childForm.ShowRect = false;
            childForm.BringToFront();
            childForm.Show();
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            TitleChildFormLabel.Text = childForm.Text;
            TitleBarPanel.Text = childForm.Text;
        }
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
        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async void LoadSvgFromUrlAsync(string fileUrl)
        {
            using HttpClient client = new();
            try
            {
                byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                using MemoryStream memoryStream = new(fileBytes);
                WebCanvas.Load(memoryStream);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar o arquivo SVG: {ex.Message}");
            }
        }




        private void AniflixView_Load(object sender, EventArgs e)
        {
            LoadSvgFromUrlAsync("https://dev.w3.org/SVG/tools/svgweb/samples/svg-files/gallardo.svg");
        }
    }
}
