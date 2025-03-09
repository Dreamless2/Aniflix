using Sunny.UI;
using FontAwesome.Sharp.Material;

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
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.IconColor = Color.Gainsboro;
                }
            }

            foreach (Control lbls in form.Controls)
            {
                if (lbls is UILabel lbl)
                {
                    lbl.ForeColor = Color.Gainsboro;
                }
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(156, 39, 176);  // #9C27B0 - Roxo
            public static Color color2 = Color.FromArgb(228, 18, 75);   // #E4126B - Rosa forte
            public static Color color3 = Color.FromArgb(234, 103, 108); // #EA676C - Rosa claro
            public static Color color4 = Color.FromArgb(255, 87, 34);   // #FF5722 - Laranja avermelhado
            public static Color color5 = Color.FromArgb(95, 77, 221);   // #3F51B5 - Azul escuro
            public static Color color6 = Color.FromArgb(33, 150, 243);  // #2196F3 - Azul vibrante
            public static Color color7 = Color.FromArgb(0, 148, 188);   // #0094BC - Azul petróleo
            public static Color color8 = Color.FromArgb(67, 183, 110);  // #43B76E - Verde médio
            public static Color color9 = Color.FromArgb(255, 152, 0);   // #FF9800 - Laranja forte
            public static Color color10 = Color.FromArgb(184, 28, 70);  // #B71C46 - Vermelho escuro
        }

    }
}
