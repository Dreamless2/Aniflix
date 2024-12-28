using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Aniflix.Extensions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using TMDbLib.Client;

namespace Aniflix;

public partial class Filmes : Window
{
    DateTime dataLancamento;

    public Filmes()
    {
        InitializeComponent();
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
        var client = new TMDbClient("1dcbf681735d3e7454953f5b7c22b6dc")
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR"
        };

        var movie = client.GetMovieAsync(txID.Text).Result;
        txTitulo.Text = movie.Title;
        txSinopse.Text = movie.Overview;
        txTituloOriginal.Text = movie.OriginalTitle;
        txDataLancamento.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
        txFranquia.Text = FormatString(txTitulo.Text);

        if (DateTime.TryParseExact(txDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataLancamento))
        {
            string ano = dataLancamento.Year.ToString();
            txTags.Text = "#Filme #Filme" + ano;
        }

        string g0 = movie.Genres[0].Name;
        string g1 = movie.Genres[0].Name;
        string g2 = movie.Genres[0].Name;

        string p0 = new(g0
            .RemoveDiacritics()
            .Where(char.IsAscii)
            .ToArray()
         );
        string p1 = new(g1
            .RemoveDiacritics()
            .Where(char.IsAscii)
            .ToArray()
         );
        string p2 = new(g2
            .RemoveDiacritics()
            .Where(char.IsAscii)
            .ToArray()
        );

        var credits = client.GetMovieCreditsAsync(Convert.ToInt32(txID.Text)).Result;
        txGenero.Text = "#" + p0.ToLower() + " " + "#" + p1.ToLower() + " " + "#" + p2.ToLower();
        var directors = credits.Crew
           .Where(person => person.Job == "Director")
           .Take(4)
           .Select(person => person.Name);

        foreach (var director in directors)
        {
            txDiretor.Text += "#" + director.ToLower() + " ";
        }
    }

    [GeneratedRegex("[^0-9]")]
    private static partial Regex isOnlyNumbers();
}