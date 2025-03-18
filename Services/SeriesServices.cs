#region "Copyright"
// Copyright (C) 2025  Tiago.NET
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion

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
        public async Task GivenData(string itemId, UITextBox tituloText, UIRichTextBox sinopseText, UITextBox tituloOriginalText,
                                    UITextBox dataLancamentoText, UITextBox tituloAlternativoText, UITextBox paisOrigemText, UITextBox idiomaOriginalText,
                                    UITextBox serieText, UITextBox criadoresText, UITextBox generoText, UITextBox tagsText,
                                    UITextBox estrelasText, UITextBox estudioText)
        {
            try
            {
                var item = await general.GetTvShowAsync(itemId);

                if (item == null || string.IsNullOrWhiteSpace(item.Name))
                {
                    MessageBox.Show("Série inválida ou título vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var country = item.ProductionCountries?.FirstOrDefault()?.Name ?? "País desconhecido";
                var language = item.SpokenLanguages?.FirstOrDefault()?.Name ?? "Idioma desconhecido";

                country = (await deepl.Translate(country)).Text;
                language = (await deepl.Translate(language)).Text;

                var itemSemAcentos = StringExtensions.RemoveAccents(
                    StringExtensions.StripPunctuation(
                        StringExtensions.RemoveDiacritics(item.Name.Replace(" ", ""))
                    )
                );

                var itemComAcentos = StringExtensions.StripPunctuation(item.Name.Replace(" ", ""));

                if (string.IsNullOrEmpty(itemSemAcentos) || string.IsNullOrEmpty(itemComAcentos))
                {
                    MessageBox.Show("Nenhuma série encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(item.Name))
                {
                    bool temAcentos = StringExtensions.HasAccents(item.Name);

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
                    var toLowerLanguage = StringExtensions.FirstCharToLower(language.ToString());

                    bool temAcentos = StringExtensions.HasAccents(toLowerLanguage);

                    idiomaOriginalText.Text = temAcentos
                        ? "#" + toLowerLanguage + " " + "#" + StringExtensions.RemoveDiacritics(toLowerLanguage.Replace(" ", ""))
                        : "#" + StringExtensions.RemoveDiacritics(toLowerLanguage.Replace(" ", ""));
                }
                else
                {
                    idiomaOriginalText.Text = "--";
                }

                if (!string.IsNullOrEmpty(country.ToString()))
                {
                    bool temAcentos = StringExtensions.HasAccents(country.ToString());

                    paisOrigemText.Text = temAcentos
                        ? "#" + country.ToString().Replace(" ", "") + " " + "#" + StringExtensions.RemoveDiacritics(country.ToString().Replace(" ", ""))
                        : "#" + StringExtensions.RemoveDiacritics(country.ToString().Replace(" ", ""));
                }
                else
                {
                    paisOrigemText.Text = "--";
                }

                tituloText.Text = item.Name ?? "--";
                sinopseText.Text = item.Overview ?? "--";
                tituloOriginalText.Text = item.OriginalName ?? "--";
                dataLancamentoText.Text = item.FirstAirDate?.ToString("dd/MM/yyyy") ?? "--";
                tituloAlternativoText.Text = item.AlternativeTitles.Results[0].Title ?? "--";
                if (DateTime.TryParseExact(dataLancamentoText.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
                {
                    tagsText.Text = $"#Serie #Serie{releaseDate.Year} #Série #Série{releaseDate.Year}";
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


                    var genre0 = await deepl.Translate(item.Genres[0].Name);
                    var genre1 = await deepl.Translate(item.Genres[1].Name);
                    var genre2 = await deepl.Translate(item.Genres[2].Name);


                    FormatGenre(genre2.ToString()!, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(genre1.ToString()!, hashtagsPrincipais, outrasHashtags);
                    FormatGenre(genre0.ToString()!, hashtagsPrincipais, outrasHashtags);

                    generoText.Text = string.Join(" ", hashtagsPrincipais.Concat(outrasHashtags));
                }

                if (item.CreatedBy != null)
                {
                    criadoresText.Text = StringExtensions.CleanString(string.Join(" ", item.CreatedBy.Take(4).Select(person => $"#{person.Name.Replace(" ", "")}")));
                }

                if (item.Credits?.Cast != null)
                {
                    estrelasText.Text = StringExtensions.CleanString(string.Join(" ", item.Credits.Cast.Take(5).Select(person => $"#{person.Name.Replace(" ", "")}")));
                }

                if (item.ProductionCompanies != null)
                {
                    estudioText.Text = StringExtensions.CleanString(string.Join(" ", item.ProductionCompanies.Take(5).Select(company => $"#{company.Name.Replace(" ", "")}")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar a série: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}