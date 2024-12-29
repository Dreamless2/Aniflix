using System;
using System.IO;
using Aniflix.Models;
using Aniflix.ViewModels;
using Avalonia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projektanker.Icons.Avalonia;
using Projektanker.Icons.Avalonia.FontAwesome;
using Projektanker.Icons.Avalonia.MaterialDesign;

namespace Aniflix
{
    public static class Program
    {
        public static IConfiguration? Configuration { get; private set; }

        [STAThread]
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            var services = new ServiceCollection();
            services.AddSingleton<AniflixDbContext>();
            services.AddTransient<FilmesViewModel>();

            _ = services.BuildServiceProvider();

            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            var connectionStriong = Configuration?.GetConnectionString("DefaultConnection");
            services.AddDbContext<AniflixDbContext>(options =>
                options.UseNpgsql(connectionStriong)
            );
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            IconProvider
                .Current.Register<FontAwesomeIconProvider>()
                .Register<MaterialDesignIconProvider>();

            return AppBuilder.Configure<App>().UsePlatformDetect();
        }
    }
}
