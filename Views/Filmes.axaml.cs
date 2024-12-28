using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Aniflix.Extensions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.Extensions.Configuration;
using TMDbLib.Client;

namespace Aniflix;

public partial class Filmes : Window
{
    DateTime dataLancamento;
    private IConfiguration? _configuration;

    public Filmes()
    {
        InitializeComponent();
        ConfigureAppSettings();
    }

    private void ConfigureAppSettings()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        _configuration = builder.Build();
    }

    private static string FormatString(string input)
    {
        return "#" + input.Replace(" ", string.Empty);
    }

    public void OnlyNumbers(object? sender, TextChangedEventArgs e)
    {
        if (isOnlyNumbers().IsMatch(txID.Text!))
        {
            txID.Text = "";
        }
    }

    public void OnLostFocus(object? sender, RoutedEventArgs e)
    {
        var appSettings = _configuration!.GetSection("AppSettings");

        //var client = new TMDbClient("1dcbf681735d3e7454953f5b7c22b6dc")
        var client = new TMDbClient(appSettings["TMDBKey"])
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
        };

        var movie = client.GetMovieAsync(txID.Text).Result;
        txTitulo.Text = movie.Title;
        txSinopse.Text = movie.Overview;
        txTituloOriginal.Text = movie.OriginalTitle;
        txDataLancamento.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
        txFranquia.Text = FormatString(txTitulo.Text);

        if (
            DateTime.TryParseExact(
                txDataLancamento.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dataLancamento
            )
        )
        {
            string ano = dataLancamento.Year.ToString();
            txTags.Text = "#Filme #Filme" + ano;
        }

        string g0 = movie.Genres[0].Name;
        string g1 = movie.Genres[1].Name;
        string g2 = movie.Genres[2].Name;

        string p0 = new(g0.RemoveDiacritics().Where(char.IsAscii).ToArray());
        string p1 = new(g1.RemoveDiacritics().Where(char.IsAscii).ToArray());
        string p2 = new(g2.RemoveDiacritics().Where(char.IsAscii).ToArray());

        var credits = client.GetMovieCreditsAsync(Convert.ToInt32(txID.Text)).Result;
        txGenero.Text = "#" + p0.ToLower() + " " + "#" + p1.ToLower() + " " + "#" + p2.ToLower();

        var directors = credits.Crew
            .Where(person => person.Job == "Director")
            .Take(4)
            .Select(person => $"#{person.Name.Replace(" ", "")}")
            .ToList();

        txDiretor.Text = string.Join(" ", directors);

        var stars = credits.Cast
          .Take(5)
          .Select(person => $"#{person.Name.Replace(" ", "")}")
          .ToList();

        txElenco.Text = string.Join(" ", stars);

        var studios = movie.ProductionCompanies
               .Take(5)
               .Select(company => $"#{company.Name.Replace(" ", "")}")
               .ToList();


        var cleanedList = studios.Select(str =>
             str.Aggregate("", (result, c) => (char.IsLetterOrDigit(c) || c == '#') ? result + c : result)
         ).ToList();

        txEstudio.Text = string.Join(" ", cleanedList);
    }

    [GeneratedRegex("[^0-9]")]
    private static partial Regex isOnlyNumbers();
}

public class AppSettings
{
    public string? TMDBKey { get; set; }

}