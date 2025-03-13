using Sunny.UI;
using Aniflix.Contracts;
using Aniflix.Extensions;
using System.Globalization;

namespace Aniflix.Services
{
    public class FilmesServices
    {
        private readonly FilmesContracts general = new();

        public async Task GivenData(string movieId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox filmeText, UITextBox tagsText, UITextBox generoText,
                                    UITextBox diretorText, UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var movie = await general.GetMovieAsync(movieId);

                var filmeSemAcentos = StringExtensions.RemoveAccents(StringExtensions.StripPunctuation(StringExtensions.RemoveDiacritics(movie!.Title.Replace(" ", "")))); ;
                var filmesAcentos = StringExtensions.StripPunctuation(movie.Title.Replace(" ", ""));

                if (movie == null)
                {
                    MessageBox.Show("Nenhum filme encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tituloText.Text = movie.Title ?? "--";
                sinopseText.Text = movie.Overview ?? "--";
                tituloOriginalText.Text = movie.OriginalTitle ?? "--";
                dataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = movie.AlternativeTitles?.Titles?.FirstOrDefault()?.Title ?? "--";
                filmeText.Text = "#" + filmesAcentos + " " + "#" + filmeSemAcentos ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Filme #Filme{releaseDate.Year}";
                }

                if (movie.Genres?.Count > 2)
                {
                    var hashtags = new HashSet<string>();
                    foreach (var genre in movie.Genres.Take(3))
                    {
                        if (!string.IsNullOrEmpty(genre?.Name))
                        {
                            string clean = new string([.. genre.Name.Normalize().Where(char.IsLetterOrDigit)]).ToLower();
                            hashtags.Add($"#{clean}");
                        }
                    }

                    static void FormatGenre(string genre, HashSet<string> hashtags)
                    {
                        Dictionary<string, string> specialWords = new()
                    {

                        { "ficção científica", "ficcaocientifica ficçãocientífica" },
                        { "romântico", "romantico romântico" },
                        { "romântica", "romantica romântica" },
                        { "comédia", "comedia comédia" },
                        { "mistério", "misterio mistério" },
                        { "ação", "acao ação" }
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
                            string clean = new([.. genre.RemoveDiacritics().Where(char.IsAscii)]);
                            hashtags.Add($"#{genre.ToLower().Replace(" ", "")}");
                            hashtags.Add($"#{clean.ToLower().Replace(" ", "")}");
                        }
                    }

                    FormatGenre(movie.Genres[1].Name, hashtags);
                    FormatGenre(movie.Genres[2].Name, hashtags);
                    FormatGenre(movie.Genres[0].Name, hashtags);
                    generoText.Text = string.Join(" ", hashtags);
                }

                if (movie.Credits?.Crew != null)
                {
                    diretorText.Text = string.Join(" ", movie.Credits.Crew.Where(person => person.Job == "Director").Take(4).Select(person => $"#{person.Name.Replace(" ", "")}"));
                }

                if (movie.Credits?.Cast != null)
                {
                    estrelasText.Text = StringExtensions.RemoveAccents(string.Join(" ", movie.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}")));
                }

                if (movie.ProductionCompanies != null)
                {
                    estudioText.Text = string.Join(" ", movie.ProductionCompanies.Take(5).Select(company => $"#{company.Name.Replace(" ", "")}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}