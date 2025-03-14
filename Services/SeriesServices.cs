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
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox paisOrigem, UITextBox idiomaOriginal,
                                    UITextBox serieText, UITextBox criadores, UITextBox generoText, UITextBox tagsText,
                                    UITextBox diretorText, UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var tv = await general.GetTvShowAsync(tvId);

                var country = await deepl.Translate(tv!.ProductionCountries[0].Name);


                if (tv == null || string.IsNullOrWhiteSpace(tv.Name))
                {
                    MessageBox.Show("Série inválida ou título vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var filmeSemAcentos = StringExtensions.RemoveAccents(
                    StringExtensions.StripPunctuation(
                        StringExtensions.RemoveDiacritics(tv.Name.Replace(" ", ""))
                    )
                );

                var filmesAcentos = StringExtensions.StripPunctuation(tv.Name.Replace(" ", ""));

                if (string.IsNullOrEmpty(filmeSemAcentos) || string.IsNullOrEmpty(filmesAcentos))
                {
                    MessageBox.Show("Nenhuma série encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(tv.Name))
                {
                    bool temAcentos = StringExtensions.HasAccents(tv.Name);

                    serieText.Text = temAcentos
                        ? "#" + filmesAcentos + " " + "#" + filmeSemAcentos
                        : "#" + filmeSemAcentos;
                }
                else
                {
                    serieText.Text = "--";
                }

                tituloText.Text = tv.Name ?? "--";
                sinopseText.Text = tv.Overview ?? "--";
                tituloOriginalText.Text = tv.OriginalName ?? "--";
                dataLancamentoText.Text = tv.FirstAirDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = tv.AlternativeTitles.Results[0].Title ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Serie #Serie{releaseDate.Year} #Série #Série{releaseDate.Year}";
                }


                if (tv.Genres?.Count > 2)
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

                    FormatGenre(tv.Genres[2].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(tv.Genres[1].Name, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(tv.Genres[0].Name, hashtagsPrincipais, outrasHashtags);

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
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}