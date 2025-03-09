using Sunny.UI;
using Aniflix.Functions;
using FontAwesome.Sharp.Material;

namespace Aniflix.Views
{
    public partial class AniflixView : UIForm
    {
        private MaterialButton? currentBtn;
        private Panel? leftBorderBtn;
        private UIForm? currentChildForm;
        private Random? random;


        public AniflixView()
        {
            InitializeComponent();
            random = new Random();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            MenuPanel.Controls.Add(leftBorderBtn);
            Text = string.Empty;
            DoubleBuffered = true;
        }


        private static (Color background, Color accent) SelectThemeColors()
        {
            Random random = new();

            // Paleta de fundos escuros
            List<Color> darkBackgrounds =
            [
                Color.FromArgb(14, 52, 65),    // #0E3441 - Azul petróleo escuro
                Color.FromArgb(34, 42, 42),    // #222A2A - Verde charleston
                Color.FromArgb(01, 47, 51),    // #014F33 - Azul paon
                Color.FromArgb(40, 65, 74),    // #28494A - Azul carvão claro
                Color.FromArgb(21, 32, 43),    // #15202B - Azul carvão
                Color.FromArgb(12, 12, 12),    // #0C0C0C - Preto intenso
                Color.FromArgb(25, 20, 20),    // #191414 - Marrom café escuro
                Color.FromArgb(15, 44, 51),    // #0F2C33 - Azul carvão escuro
                Color.FromArgb(25, 31, 37),    // #191F25 - Preto carvão
                Color.FromArgb(0, 36, 50),     // #002432 - Ocean Obsidian
                Color.FromArgb(49, 70, 90),    // #314E5A - Charcoal
                Color.FromArgb(30, 99, 106),   // #1E6369 - Ivy
                Color.FromArgb(47, 11, 73),    // #2F0B49 - Violeta russo
                Color.FromArgb(1, 61, 90),     // #013D5A - Midnight
                Color.FromArgb(58, 58, 59),    // #3A3A45 - Arsenico
                Color.FromArgb(52, 63, 66),    // #343F42 - Onyx
                Color.FromArgb(45, 48, 41),    // #2D3033 - Preto Carvão escuro
                Color.FromArgb(18, 17,12),     // #12110C - Obsidiana
                Color.FromArgb(43, 15, 21),    // #2B0F15 - Zinnwaldita
                Color.FromArgb(40,17, 13),     // #28110D - Ember
            ];

            // Paleta de cores de destaque
            List<Color> accentColors =
            [
                Color.FromArgb(246, 114, 75),   // #F6724B - Laranja mandarin
                Color.FromArgb(225, 149, 71),   // #E19547 - Laranja jasper
                Color.FromArgb(212, 163, 107),  // #D4A36B - Laranja tangerina crayon
                Color.FromArgb(255, 152, 0),    // #FF9800 - Laranja vibrante
                Color.FromArgb(247, 199, 103),  // #F7C767 - Laranja crayon
                Color.FromArgb(255, 87, 34),    // #FF5722 - Laranja avermelhado
                Color.FromArgb(73, 193, 152),   // #49C195 - Verde oceano
                Color.FromArgb(245, 110, 15),   // #F56E0F - Orange Lava
                Color.FromArgb(255, 103, 90),   // #FF675A - Bittersweet
                Color.FromArgb(255, 190, 152),  // #FFBE98 - Peach fuzz
                Color.FromArgb(237, 90, 52),    // #ED5E34 - Laranja soda
                Color.FromArgb(252,214,174),    // #FCD6AE - Abricó light
                Color.FromArgb(221, 112, 95),   // #DD705F - Terra Cotta
                Color.FromArgb(0, 168, 107),    // #00A86B - Jade
                Color.FromArgb(240, 115, 55),   // #F07337 - Siena queimado
                Color.FromArgb(1, 180, 155),    // #01B49B - Keppel
                Color.FromArgb(243, 124, 52),   // #F37C34 - Cadmio
                Color.FromArgb(162, 220, 163),  // #A2DCC3 - Maçã verde
                Color.FromArgb(105, 160, 108),  // #69A06C - Oxley
                Color.FromArgb(56, 147, 114),   // #388F72 - Esmeralda
            ];

            int bgIndex = random.Next(darkBackgrounds.Count);
            int accentIndex = random.Next(accentColors.Count);

            return (darkBackgrounds[bgIndex], accentColors[accentIndex]);
        }
        private void ActivateButton(object btnSender)
        {
            var (backgroundColor, accentColor) = SelectThemeColors();
            var color = Color.FromArgb(37, 36, 81);

            if (btnSender != null)
            {
                if (currentBtn != (MaterialButton)btnSender)
                {
                    DisableButton();

                    currentBtn = (MaterialButton)btnSender;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = accentColor;
                    currentBtn.IconColor = accentColor;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                    TitleBarPanel.BackColor = backgroundColor;
                    TitleBarPanel.FillColor = backgroundColor;
                    TitleBarPanel.TitleColor = backgroundColor;
                    TitleBarPanel.TitleForeColor = accentColor;
                    TitleBarPanel.RectColor = backgroundColor;

                    LogoPanel.BackColor = color;
                    LogoPanel.FillColor = color;

                    MenuPanel.BackColor = color;
                    MenuPanel.FillColor = color;

                    leftBorderBtn!.BackColor = accentColor;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    ThemeColor.PrimaryColor = backgroundColor;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(backgroundColor, -0.55);

                    CurrentChildFormBox.IconChar = currentBtn.IconChar;
                    CurrentChildFormBox.IconColor = accentColor;
                    CurrentChildFormBox.ForeColor = accentColor;

                    TitleChildFormLabel.ForeColor = accentColor;

                    this.TitleColor = backgroundColor;
                }
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn!.Visible = false;
            currentBtn = null;
            TitleBarPanel.BackColor = Color.FromArgb(0, 150, 136);
            MenuPanel.BackColor = Color.FromArgb(39, 39, 58);
            TitleChildFormLabel.Text = "Home";
            CurrentChildFormBox.IconChar = FontAwesome.Sharp.MaterialIcons.Home;
        }
        private void OpenChildForm(UIForm childForm, object btnSender)
        {

            var (backgroundColor, accentColor) = SelectThemeColors();
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.TitleColor = accentColor;
            childForm.RectColor = backgroundColor;
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
    }
}
