using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Services
{
    public class FilmesServices
    {
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://api.themoviedb.org/3/"),
            DefaultRequestHeaders = { { "Authorization", "Bearer" } }
        };

        public async Task<T?> GetFromTmdbAsync<T>(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar {endpoint}: {ex.Message}");
                return default;
            }
        }

        /*public async Task<Movie?> GetMovieAsync(string movieId)
            => await GetFromTmdbAsync<Movie>($"movie/{movieId}");

        public async Task<Credits?> GetMovieCreditsAsync(int movieId)
            => await GetFromTmdbAsync<Credits>($"movie/{movieId}/credits");

        public async Task<AlternativeTitles?> GetMovieAlternativeTitlesAsync(int movieId)
            => await GetFromTmdbAsync<AlternativeTitles>($"movie/{movieId}/alternative_titles");
        */
    }
}
