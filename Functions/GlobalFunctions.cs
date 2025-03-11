using Sunny.UI;
using FontAwesome.Sharp.Material;
using SharpVectors.Renderers.Forms;

namespace Aniflix.Functions
{
    public static class GlobalFunctions
    {
        public static void ApplyTheme(this Form form)
        {
            foreach (Control btns in form.Controls)
            {
                if (btns is MaterialButton btn)
                {
                    btn.BackColor = Color.FromArgb(2, 47, 86);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.IconColor = Color.Gainsboro;
                }
            }

            foreach (Control lbls in form.Controls)
            {
                if (lbls is UILabel lbl)
                {
                    lbl.ForeColor = Color.White;
                }
            }

            foreach (Control txts in form.Controls)
            {
                if (txts is UITextBox txt)
                {
                    txt.BackColor = Color.FromArgb(2, 47, 86);
                    txt.ForeColor = Color.Gainsboro;
                    txt.FillColor = Color.FromArgb(2, 47, 86);
                    txt.RectColor = Color.FromArgb(2, 47, 86);
                }
            }

            foreach (Control rtxts in form.Controls)
            {
                if (rtxts is UIRichTextBox rtxt)
                {
                    rtxt.BackColor = Color.FromArgb(2, 47, 86);
                    rtxt.ForeColor = Color.Gainsboro;
                    rtxt.FillColor = Color.FromArgb(2, 47, 86);
                    rtxt.RectColor = ThemeColor.SecondaryColor;
                }
            }

            foreach (Control cboxs in form.Controls)
            {
                if (cboxs is UIComboBox cbox)
                {
                    cbox.BackColor = Color.FromArgb(2, 47, 86);
                    cbox.ForeColor = Color.Gainsboro;
                    cbox.FillColor = Color.FromArgb(2, 47, 86);
                    cbox.RectColor = ThemeColor.SecondaryColor;
                }
            }
        }

        public static (Color background, Color accent) SelectThemeColors()
        {
            Random random = new();

            // Paleta de fundos escuros
            List<Color> darkBackgrounds =
            [
                Color.FromArgb(28, 40, 51),    // #1C2833 - Azul grafite
                Color.FromArgb(50, 55, 61),    // #32373D - Cinza fosco
                Color.FromArgb(14, 28, 28),    // #0E1C1C - Azul Asteca
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
                Color.FromArgb(21, 25, 30),    // #15191E - Eerie Black
             ];

            // Paleta de cores de destaque
            List<Color> accentColors =
            [
                Color.FromArgb(246, 114, 75),   // #F6724B - Laranja mandarin
                Color.FromArgb(222, 128, 70),   // #DE8046 - Laranja tigre
                Color.FromArgb(212, 163, 107),  // #D4A36B - Laranja tangerina crayon
                Color.FromArgb(255, 78, 69),    // #FF4E45 - Vermelho quente
                Color.FromArgb(202, 86, 86),    // #CA5656 - Vermelho indiano
                Color.FromArgb(249, 206, 117),  // #F9CE75 - Laranja topazio
                Color.FromArgb(125, 209, 172),  // #7DD1AC - Aqua
                Color.FromArgb(73, 193, 152),   // #49C195 - Verde oceano
                Color.FromArgb(219, 48, 48),    // #DB3030 - Carmesim
                Color.FromArgb(255, 103, 90),   // #FF675A - Bittersweet
                Color.FromArgb(84, 186, 147),   // #54BA93 - Verde Electra
                Color.FromArgb(229, 166, 87),   // #E5A657 - Honeycomb
                Color.FromArgb(252,214,174),    // #FCD6AE - Abricó light
                Color.FromArgb(221, 112, 95),   // #DD705F - Terra Cotta
                Color.FromArgb(0, 168, 107),    // #00A86B - Jade
                Color.FromArgb(240, 115, 55),   // #F07337 - Siena queimado
                Color.FromArgb(1, 180, 155),    // #01B49B - Keppel
                Color.FromArgb(243, 124, 52),   // #F37C34 - Cadmio
                Color.FromArgb(202, 63, 22),    // #CA3F16 - Molho picante
                Color.FromArgb(255, 78, 69),    // #FF4E45 - Branco perfeito
                Color.FromArgb(56, 147, 114),   // #388F72 - Esmeralda
                Color.FromArgb(230, 143, 21),   // #E68F15 - Gamboge
                Color.FromArgb(246, 146, 104),  // #F69268 - Melon red
                Color.FromArgb(229, 117, 106),  // #E5756A - Coral ardente
                Color.FromArgb(231, 93, 80),    // #E75D50 - Chama de opala


            ];

            int bgIndex = random.Next(darkBackgrounds.Count);
            int accentIndex = random.Next(accentColors.Count);

            return (darkBackgrounds[bgIndex], accentColors[accentIndex]);
        }

        public static async void LoadSvgFromUrlAsync(string fileUrl, SvgPictureBox svgPictureBox)
        {
            using HttpClient client = new();
            try
            {
                byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                using MemoryStream memoryStream = new(fileBytes);
                svgPictureBox.Load(memoryStream);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar o arquivo SVG: {ex.Message}");
            }
        }
    }
}
