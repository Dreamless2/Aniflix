using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Aniflix.Extensions;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Microsoft.Extensions.Configuration;
using MsBox.Avalonia;
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

    public void OnlyNumbers(object? sender, TextInputEventArgs e)
    {
        if (isOnlyNumbers().IsMatch(txCodigo.Text!))
        {
            txCodigo.Text = "";
        }
    }

    public async void SearchMovies(object? sender, RoutedEventArgs e)
    {
        if (String.IsNullOrEmpty(txCodigo.Text))
        {
            await MessageBoxManager
                .GetMessageBoxStandard("Error", "Informe o id do filme.")
                .ShowAsync();
            txCodigo.Focus();
            return;
        }

        var appSettings = _configuration!.GetSection("AppSettings");

        var client = new TMDbClient(appSettings["TMDBKey"])
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
        };

        var movie = client.GetMovieAsync(txCodigo.Text).Result;

        if (movie != null)
        {
            txTitulo.Text = movie.Title;
            txSinopse.Text = movie.Overview;
            txTituloOriginal.Text = movie.OriginalTitle;
            txDataLancamento.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
            txFranquia.Text = FormatString(txTitulo.Text);
        }
        else
        {
            await MessageBoxManager
                .GetMessageBoxStandard("Error", "Nenhum filme encontrado.")
                .ShowAsync();
            txCodigo.Focus();
            return;
        }

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

        if (movie.Genres.Count > 2)
        {
            HashSet<string> hashtags = [];

            static void FormatGenre(string genre, HashSet<string> hashtags)
            {
                Dictionary<string, string> specialWords = new()
                {
                    { "fic��o cient�fica", "fic��ocient�fica ficcaocientifica" },
                    { "rom�ntico", "rom�ntico romantico" },
                    { "rom�ntica", "rom�ntica romantica" },
                    { "com�dia", "com�dia comedia" },
                    { "mist�rio", "mist�rio misterio" },
                };

                string lowerGenre = genre.ToLower();

                if (specialWords.TryGetValue(lowerGenre, out string? value))
                {
                    foreach (var tag in value.Split(' '))
                    {
                        hashtags.Add($"#{tag}");
                    }
                }
                else
                {
                    string clean = new(genre.RemoveDiacritics().Where(char.IsAscii).ToArray());
                    hashtags.Add($"#{genre.ToLower().Replace(" ", "")}");
                    hashtags.Add($"#{clean.ToLower().Replace(" ", "")}");
                }
            }

            FormatGenre(movie.Genres[0].Name, hashtags);
            FormatGenre(movie.Genres[1].Name, hashtags);
            FormatGenre(movie.Genres[2].Name, hashtags);
            txGenero.Text = string.Join(" ", hashtags);
        }

        var credits = client.GetMovieCreditsAsync(Convert.ToInt32(txCodigo.Text)).Result;
        var directors = credits
            .Crew.Where(person => person.Job == "Director")
            .Take(4)
            .Select(person => $"#{person.Name.Replace(" ", "")}")
            .ToList();

        txDiretor.Text = string.Join(" ", directors);

        var stars = credits
            .Cast.Take(5)
            .Select(person => $"#{person.Name.Replace(" ", "")}")
            .ToList();

        txEstrelas.Text = string.Join(" ", stars);

        var studios = movie
            .ProductionCompanies.Take(5)
            .Select(company => $"#{company.Name.Replace(" ", "")}")
            .ToList();

        var cleanedList = studios
            .Select(str =>
                str.Aggregate(
                    "",
                    (result, c) => (char.IsLetterOrDigit(c) || c == '#') ? result + c : result
                )
            )
            .ToList();

        txEstudio.Text = string.Join(" ", cleanedList);
    }

    public void CopyData(object? sender, RoutedEventArgs e)
    {
        txData.SelectAll();
        txData.Copy();
    }

    [GeneratedRegex("[^0-9]")]
    private static partial Regex isOnlyNumbers();
}

public class AppSettings
{
    public string? TMDBKey { get; set; }
}
