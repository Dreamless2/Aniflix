using System;
using System.Linq;
using System.Text;
using Aniflix.Views;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SobreView());
        }
    }
}
