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
        }
    }
}
