using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;

namespace Aniflix.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void OpenMovies(object sender, RoutedEventArgs e)
        {
            var window = new Filmes();
            window.Show();
        }

        public static void ExitApp(object sender, RoutedEventArgs e)
        {
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopApp)
            {
                desktopApp.Shutdown();
            }
            else if (Application.Current?.ApplicationLifetime is ISingleViewApplicationLifetime viewApp)
            {
                viewApp.MainView = null;
            }
        }
    }
}