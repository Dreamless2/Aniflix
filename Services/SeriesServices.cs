using Sunny.UI;
using Aniflix.Contracts;
using Aniflix.Extensions;
using System.Globalization;

namespace Aniflix.Services
{
    public class SeriesServices
    {
        private readonly TMDBContracts general = new();
        private readonly DEEPLContracts deepl = new();
        public async Task GivenData(string tvId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox paisOrigemText, UITextBox idiomaOriginalText,
                                    UITextBox serieText, UITextBox criadoresText, UITextBox generoText, UITextBox tagsText,
                                    UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var series = await general.GetTvShowAsync(tvId);

                var country = await deepl.Translate(series!.ProductionCountries[0].Name);
                var language = await deepl.Translate(series.SpokenLanguages[0].Name);

                if (series == null || string.IsNullOrWhiteSpace(series.Name))
                {
                    MessageBox.Show("Série inválida ou título vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var itemSemAcentos = StringExtensions.RemoveAccents(
                    StringExtensions.StripPunctuation(
                        StringExtensions.RemoveDiacritics(series.Name.Replace(" ", ""))
                    )
                );

                var itemComAcentos = StringExtensions.StripPunctuation(series.Name.Replace(" ", ""));

                if (string.IsNullOrEmpty(itemSemAcentos) || string.IsNullOrEmpty(itemComAcentos))
                {
                    MessageBox.Show("Nenhuma série encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(series.Name))
                {
                    bool temAcentos = StringExtensions.HasAccents(series.Name);

                    serieText.Text = temAcentos
                        ? "#" + itemComAcentos + " " + "#" + itemSemAcentos
                        : "#" + itemSemAcentos;
                }
                else
                {
                    serieText.Text = "--";
                }

                if (!string.IsNullOrEmpty(language.ToString()))
                {
                    bool temAcentos = StringExtensions.HasAccents(language.ToString());

                    idiomaOriginalText.Text = temAcentos
                        ? "#" + language.ToString() + " " + "#" + StringExtensions.RemoveDiacritics(language.ToString().Replace(" ", ""))
                        : "#" + StringExtensions.RemoveDiacritics(language.ToString().Replace(" ", ""));
                }
                else
                {
                    idiomaOriginalText.Text = "--";
                }

                if (!string.IsNullOrEmpty(country.ToString()))
                {
                    bool temAcentos = StringExtensions.HasAccents(country.ToString());

                    paisOrigemText.Text = temAcentos
                        ? "#" + country.ToString() + " " + "#" + StringExtensions.RemoveDiacritics(country.ToString().Replace(" ", ""))
                        : "#" + StringExtensions.RemoveDiacritics(country.ToString().Replace(" ", ""));
                }
                else
                {
                    paisOrigemText.Text = "--";
                }

                tituloText.Text = series.Name ?? "--";
                sinopseText.Text = series.Overview ?? "--";
                tituloOriginalText.Text = series.OriginalName ?? "--";
                dataLancamentoText.Text = series.FirstAirDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = series.AlternativeTitles.Results[0].Title ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Serie #Serie{releaseDate.Year} #Série #Série{releaseDate.Year}";
                }


                if (series.Genres?.Count > 2)
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

                    FormatGenre(deepl.Translate(series.Genres[2].Name), hashtagsPrincipais, outrasHashtags);
                    FormatGenre(series.Genres[1].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(series.Genres[0].Name, hashtagsPrincipais, outrasHashtags);

                    generoText.Text = string.Join(" ", hashtagsPrincipais.Concat(outrasHashtags));
                }

                if (series.CreatedBy != null)
                {
                    criadoresText.Text = string.Join(" ", series.CreatedBy.Take(4).Select(person => $"#{person.Name.Replace(" ", "")}"));
                }

                if (series.Credits?.Cast != null)
                {
                    estrelasText.Text = string.Join(" ", series.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}"));
                }

                if (series.ProductionCompanies != null)
                {
                    estudioText.Text = string.Join(" ", series.ProductionCompanies.Take(5).Select(company => $"#{company.Name.Replace(" ", "")}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar a série: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}