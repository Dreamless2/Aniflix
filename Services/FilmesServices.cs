using Sunny.UI;
using Aniflix.Contracts;
using Aniflix.Extensions;
using System.Globalization;

namespace Aniflix.Services
{
    public class FilmesServices
    {
        private readonly TMDBContracts general = new();
        public async Task GivenData(string filmeId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox filmeText, UITextBox tagsText, UITextBox generoText,
                                    UITextBox diretorText, UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var item = await general.GetMovieAsync(itemId);

                if (item == null || string.IsNullOrWhiteSpace(item.Title))
                {
                    MessageBox.Show("Filme inválido ou título vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var itemSemAcentos = StringExtensions.RemoveAccents(
                    StringExtensions.StripPunctuation(
                        StringExtensions.RemoveDiacritics(item.Title.Replace(" ", ""))
                    )
                );

                var itemComAcentos = StringExtensions.StripPunctuation(item.Title.Replace(" ", ""));

                if (string.IsNullOrEmpty(itemSemAcentos) || string.IsNullOrEmpty(itemComAcentos))
                {
                    MessageBox.Show("Nenhum filme encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(item.Title))
                {
                    bool temAcentos = StringExtensions.HasAccents(item.Title);

                    filmeText.Text = temAcentos
                        ? "#" + itemComAcentos + " " + "#" + itemSemAcentos
                        : "#" + itemSemAcentos;
                }
                else
                {
                    filmeText.Text = "--";
                }

                tituloText.Text = item.Title ?? "--";
                sinopseText.Text = item.Overview ?? "--";
                tituloOriginalText.Text = item.OriginalTitle ?? "--";
                dataLancamentoText.Text = item.ReleaseDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = item.AlternativeTitles?.Titles?.FirstOrDefault()?.Title ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Filme #Filme{releaseDate.Year}";
                }


                if (item.Genres?.Count > 2)
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

                    FormatGenre(item.Genres[2].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(item.Genres[1].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(item.Genres[0].Name, hashtagsPrincipais, outrasHashtags);

                    generoText.Text = string.Join(" ", hashtagsPrincipais.Concat(outrasHashtags));
                }

                if (item.Credits?.Crew != null)
                {
                    diretorText.Text = StringExtensions.CleanString(string.Join(" ", item.Credits.Crew.Where(person => person.Job == "Director").Take(4).Select(person => $"#{person.Name.Replace(" ", "")}")));
                }

                if (item.Credits?.Cast != null)
                {
                    estrelasText.Text = StringExtensions.CleanString(StringExtensions.RemoveAccents(string.Join(" ", item.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}"))));
                }

                if (item.ProductionCompanies != null)
                {
                    estudioText.Text = StringExtensions.CleanString(string.Join(" ", item.ProductionCompanies.Take(5).Select(company => $"#{company.Name.Replace(" ", "")}")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}