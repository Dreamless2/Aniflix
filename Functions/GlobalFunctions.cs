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
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.IconColor = Color.Gainsboro;
                }
            }
        }
    }
}
