using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace Aniflix.Contracts
{
    public class FilmesContracts
    {
        private readonly TMDbClient _client = new("d1f15ac0632492b3c3a940032ad6b95b")
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
            Timeout = TimeSpan.FromSeconds(600)
        };

        public async Task<Movie?> GetMovieAsync(string movieId)
            => await _client.GetMovieAsync(int.Parse(movieId), MovieMethods.Credits | MovieMethods.AlternativeTitles);      

    }
}