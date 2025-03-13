using Sunny.UI;
using Aniflix.Contracts;
using Aniflix.Functions;
using System.Globalization;

namespace Aniflix.Services
{
    public class FilmesServices
    {
        private readonly FilmesContracts general = new();

        public async Task GivenData(string movieId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox tagsText, UITextBox generoText,
                                    UITextBox diretorText, UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                //var general = FilmesContracts.MovieDatabase();
                var movieTask = general.GetMovieAsync(movieId);
                //var creditsTask = general.GetMovieCreditsAsync(Convert.ToInt32(movieId));
                //                var alternativeTitlesTask = general.GetMovieAlternativeTitlesAsync(Convert.ToInt32(movieId));

                //await Task.WhenAll(movieTask, creditsTask, alternativeTitlesTask);

                var movie = movieTask.Result;
                //var credits = creditsTask.Result;
                //var alternativeTitles = alternativeTitlesTask.Result;

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
                            string clean = new string(genre.Name.Normalize().Where(char.IsLetterOrDigit).ToArray()).ToLower();
                            hashtags.Add($"#{clean}");
                        }
                    }
                    generoText.Text = string.Join(" ", hashtags);
                }

                if (movie.Credits?.Crew != null)
                {
                    diretorText.Text = string.Join(" ", movie.Credits.Crew.Where(person => person.Job == "Director").Take(4).Select(person => $"#{person.Name.Replace(" ", "")}"));
                }

                if (movie.Credits?.Cast != null)
                {
                    estrelasText.Text = string.Join(" ", movie.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}"));
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