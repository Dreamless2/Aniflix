using Sunny.UI;
using Aniflix.Contracts;
using Aniflix.Extensions;
using System.Globalization;

namespace Aniflix.Services
{
    public class FilmesServices
    {
        private readonly TMDBContracts general = new();
        public async Task GivenData(string movieId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox filmeText, UITextBox tagsText, UITextBox generoText,
                                    UITextBox diretorText, UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var movie = await general.GetMovieAsync(movieId);

                if (movie == null || string.IsNullOrWhiteSpace(movie.Title))
                {
                    MessageBox.Show("Filme inválido ou título vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var itemSemAcentos = StringExtensions.RemoveAccents(
                    StringExtensions.StripPunctuation(
                        StringExtensions.RemoveDiacritics(movie.Title.Replace(" ", ""))
                    )
                );

                var itemComAcentos = StringExtensions.StripPunctuation(movie.Title.Replace(" ", ""));

                if (string.IsNullOrEmpty(itemSemAcentos) || string.IsNullOrEmpty(itemComAcentos))
                {
                    MessageBox.Show("Nenhum filme encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(movie.Title))
                {
                    bool temAcentos = StringExtensions.HasAccents(movie.Title);

                    filmeText.Text = temAcentos
                        ? "#" + itemComAcentos + " " + "#" + itemSemAcentos
                        : "#" + itemSemAcentos;
                }
                else
                {
                    filmeText.Text = "--";
                }

                tituloText.Text = movie.Title ?? "--";
                sinopseText.Text = movie.Overview ?? "--";
                tituloOriginalText.Text = movie.OriginalTitle ?? "--";
                dataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = movie.AlternativeTitles?.Titles?.FirstOrDefault()?.Title ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Filme #Filme{releaseDate.Year}";
                }


                if (movie.Genres?.Count > 2)
                {
                    var hashtagsPrincipais = new HashSet<string>();
                    var outrasHashtags = new HashSet<string>();

                    static void FormatGenre(string genre, HashSet<string> hashtagsPrincipais, HashSet<string> outrasHashtags)
                    {
                        Dictionary<string, string> specialWords = new()
                        {
                            { "ficção científica", "ficçãocientífica ficcaocientifica" },
                            { "romântico", "romântico romantico" },
                            { "romântica", "romântica romantica" },
                            { "comédia", "comédia comedia" },
                            { "mistério", "mistério misterio" },
                            { "ação", "ação acao" }
                        };

                        string lowerGenre = genre.ToLower();

                        if (specialWords.TryGetValue(lowerGenre, out string? value))
                        {
                            foreach (var tag in value.Split(' '))
                            {
                                hashtagsPrincipais.Add($"#{tag}");
                            }
                        }
                        else
                        {
                            string clean = new([.. genre.RemoveDiacritics().Where(char.IsAscii)]);
                            outrasHashtags.Add($"#{genre.ToLower().Replace(" ", "")}");
                            outrasHashtags.Add($"#{clean.ToLower().Replace(" ", "")}");
                        }
                    }

                    FormatGenre(movie.Genres[2].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(movie.Genres[1].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(movie.Genres[0].Name, hashtagsPrincipais, outrasHashtags);

                    generoText.Text = string.Join(" ", hashtagsPrincipais.Concat(outrasHashtags));
                }

                if (movie.Credits?.Crew != null)
                {
                    diretorText.Text = string.Join(" ", movie.Credits.Crew.Where(person => person.Job == "Director").Take(4).Select(person => $"#{person.Name.Replace(" ", "")}"));
                }

                if (movie.Credits?.Cast != null)
                {
                    estrelasText.Text = StringExtensions.CleanString(StringExtensions.RemoveAccents(string.Join(" ", movie.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}"))));
                }

                if (movie.ProductionCompanies != null)
                {
                    estudioText.Text = StringExtensions.CleanString(string.Join(" ", movie.ProductionCompanies.Take(5).Select(company => $"#{company.Name.Replace(" ", "")}")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}