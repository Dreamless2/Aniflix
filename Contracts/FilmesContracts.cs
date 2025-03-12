using Sunny.UI;
using TMDbLib.Client;
using System.Text.Json;
using Aniflix.Functions;
using TMDbLib.Objects.Movies;

namespace Aniflix.Contracts
{
    public class FilmesContracts
    {
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://api.themoviedb.org/3/"),
            DefaultRequestHeaders = { { "Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJkMWYxNWFjMDYzMjQ5MmIzYzNhOTQwMDMyYWQ2Yjk1YiIsIm5iZiI6MTc0MDYwOTk2MS40NDk5OTk4LCJzdWIiOiI2N2JmOTlhOThjMzg2YzRlNWJjOGMyMWQiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.-UvZqVY1yZ9_6Yjk9qh1WaKwop07J4pgOvKlcZZIREQ" } }
        };

        public async Task<T?> GetFromTmdbAsync<T>(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                string json = await response.Content.ReadAsStringAsync();

                UIMessageBox.ShowWarning($"[DEBUG] JSON Recebido para {endpoint}:\n{json}");

                response.EnsureSuccessStatusCode();
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"Erro ao buscar {endpoint}: {ex.Message}");
                return default;
            }
        }

        public async Task<Movie?> GetMovieAsync(string movieId)
            => await GetFromTmdbAsync<Movie>($"movie/{movieId}");

        public async Task<Credits?> GetMovieCreditsAsync(int movieId)
            => await GetFromTmdbAsync<Credits>($"movie/{movieId}/credits");

        public async Task<AlternativeTitles?> GetMovieAlternativeTitlesAsync(int movieId)
            => await GetFromTmdbAsync<AlternativeTitles>($"movie/{movieId}/alternative_titles");

        public static TMDbClient MovieDatabase()
        {
            var client = new TMDbClient("d1f15ac0632492b3c3a940032ad6b95b")
            {
                DefaultLanguage = "pt-BR",
                DefaultCountry = "BR",
                Timeout = TimeSpan.FromSeconds(600)
            };

            return client;
        }

    }
}