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
                    btn.BackColor = Color.FromArgb(41, 43, 41);
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
    }
}
