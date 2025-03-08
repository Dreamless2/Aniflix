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
                Color.FromArgb(249, 88, 155),   // #F9589B - Rosa chiclete
                Color.FromArgb(255, 152, 0),    // #FF9800 - Laranja vibrante
                Color.FromArgb(88, 132, 130),   // #587482 - Verde sonho de inverno
                Color.FromArgb(255, 87, 34),    // #FF5722 - Laranja avermelhado
                Color.FromArgb(240, 170, 70),   // #F0AA46 - Amarelo hunyadi
                Color.FromArgb(245, 110, 15),   // #F56E0F - Orange Lava
                Color.FromArgb(255, 103, 90),   // #FF675A - Bittersweet
                Color.FromArgb(255, 190, 152),  // #FFBE98 - Peach fuzz
                Color.FromArgb(237, 90, 52),    // #ED5E34 - Laranja soda
                Color.FromArgb(252,214,174),    // #FCD6AE - Abricó light
                Color.FromArgb(221, 112, 95),   // #DD705F - Terra Cotta
                Color.FromArgb(233, 72, 69),    // #E94845 - Rosa carmin
                Color.FromArgb(240, 115, 55),   // #F07337 - Siena queimado
                Color.FromArgb(1, 180, 155),    // #01B49B - Keppel
                Color.FromArgb(243, 124, 52),   // #F37C34 - Cadmio
                Color.FromArgb(0, 156, 82),     // #009C52 - Shamrock green
                Color.FromArgb(105, 160, 108),  // #69A06C - Oxley
                Color.FromArgb(217, 63, 64),    // #D93F40 - Jasper

            ];

            int bgIndex = random.Next(darkBackgrounds.Count);
            int accentIndex = random.Next(accentColors.Count);

            return (darkBackgrounds[bgIndex], accentColors[accentIndex]);
        }
        private void ActivateButton(object btnSender)
        {
            var (backgroundColor, accentColor) = SelectThemeColors();

            if (btnSender != null)
            {
                if (currentBtn != (MaterialButton)btnSender)
                {
                    DisableButton();
                    currentBtn = (MaterialButton)btnSender;
                    currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.IconColor = accentColor;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    TitleBarPanel.BackColor = backgroundColor;
                    TitleBarPanel.FillColor = backgroundColor;
                    TitleBarPanel.TitleColor = backgroundColor;
                    TitleBarPanel.TitleForeColor = Color.Gainsboro;
                    LogoPanel.BackColor = backgroundColor;
                    LogoPanel.FillColor = backgroundColor;
                    MenuPanel.BackColor = ThemeColor.ChangeColorBrightness(backgroundColor, -0.55);
                    MenuPanel.FillColor = ThemeColor.ChangeColorBrightness(backgroundColor, -0.55);
                    leftBorderBtn!.BackColor = ThemeColor.ChangeColorBrightness(backgroundColor, 1.0);
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    ThemeColor.PrimaryColor = backgroundColor;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(backgroundColor, -0.3);
                    CurrentChildFormBox.IconChar = currentBtn.IconChar;
                    CurrentChildFormBox.IconColor = Color.Gainsboro;
                    CurrentChildFormBox.ForeColor = Color.Gainsboro;
                    TitleChildFormLabel.ForeColor = Color.FromArgb(255, 87, 34); // #FF5722 - Laranja Avermelhado
                }
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
        private void Reset()
        {
            DisableButton();
            currentBtn = null;
            TitleBarPanel.BackColor = Color.FromArgb(0, 150, 136);
            MenuPanel.BackColor = Color.FromArgb(39, 39, 58);
            TitleChildFormLabel.Text = "Home";
            CurrentChildFormBox.IconChar = FontAwesome.Sharp.MaterialIcons.Home;
        }
        private void OpenChildForm(UIForm childForm, object btnSender)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
    }
}
