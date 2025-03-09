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
                Color.FromArgb(28, 40, 51),    // #1C2833 - Azul grafite
                Color.FromArgb(22, 30, 41),    // #161E29 - Preto carvão profundo
                Color.FromArgb(35, 45, 55),    // #232D37 - Azul aço
                Color.FromArgb(17, 24, 39),    // #111827 - Azul meia-noite
                Color.FromArgb(20, 29, 38),    // #141D26 - Azul petróleo intenso
                Color.FromArgb(30, 30, 30),    // #1E1E1E - Preto carvão suave
                Color.FromArgb(37, 37, 37),    // #252525 - Cinza asfalto
                Color.FromArgb(23, 33, 43),    // #17212B - Azul carvão
                Color.FromArgb(27, 38, 44),    // #1B262C - Azul aço profundo
                Color.FromArgb(18, 32, 47),    // #12202F - Azul meia-noite intenso
                Color.FromArgb(45, 52, 54),    // #2D3436 - Grafite elegante
                Color.FromArgb(38, 50, 56),    // #263238 - Azul industrial
                Color.FromArgb(25, 25, 28),    // #19191C - Preto fosco
                Color.FromArgb(43, 45, 66),    // #2B2D42 - Azul noite
                Color.FromArgb(15, 23, 42),    // #0F172A - Azul cobalto intenso
                Color.FromArgb(12, 20, 28),    // #0C141C - Preto celestial
                Color.FromArgb(33, 37, 41),    // #212529 - Preto cinza elegante
                Color.FromArgb(19, 24, 29),    // #13181D - Azul eclipse
                Color.FromArgb(30, 36, 48),    // #1E2430 - Preto grafite metálico
                Color.FromArgb(44, 62, 80)     // #2C3E50 - Azul aço azulado
            ];

            // Paleta de cores de destaque
            List<Color> accentColors =
            [
                Color.FromArgb(246, 114, 75),   // #F6724B - Laranja mandarin
                Color.FromArgb(222, 128, 70),   // #DE8046 - Laranja tigre
                Color.FromArgb(212, 163, 107),  // #D4A36B - Laranja tangerina crayon
                Color.FromArgb(255, 152, 0),    // #FF9800 - Laranja vibrante
                Color.FromArgb(202, 86, 86),    // #CA5656 - Vermelho indiano
                Color.FromArgb(249, 206, 117),  // #F9CE75 - Laranja topazio
                Color.FromArgb(125, 209, 172),  // #7DD1AC - Aqua
                Color.FromArgb(73, 193, 152),   // #49C195 - Verde oceano
                Color.FromArgb(255, 178, 203),  // #FFB2CB - Cherry blossom
                Color.FromArgb(255, 103, 90),   // #FF675A - Bittersweet
                Color.FromArgb(121, 197, 163),  // #79C5A3 - Verde sheen
                Color.FromArgb(237, 90, 52),    // #ED5E34 - Laranja soda
                Color.FromArgb(252,214,174),    // #FCD6AE - Abricó light
                Color.FromArgb(221, 112, 95),   // #DD705F - Terra Cotta
                Color.FromArgb(0, 168, 107),    // #00A86B - Jade
                Color.FromArgb(240, 115, 55),   // #F07337 - Siena queimado
                Color.FromArgb(1, 180, 155),    // #01B49B - Keppel
                Color.FromArgb(243, 124, 52),   // #F37C34 - Cadmio
                Color.FromArgb(255, 62, 115),   // #FF3E73 - Rose
                Color.FromArgb(169, 211, 197),  // #A9D3C5 - Azul pastel
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
