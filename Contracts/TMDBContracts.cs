using Aniflix.Functions;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;

namespace Aniflix.Contracts
{
    public class TMDBContracts
    {
        private readonly TMDbClient _client = new(GlobalVars.TMDB_KEY)
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
            Timeout = TimeSpan.FromSeconds(600)
        };

        public async Task<Movie?> GetMovieAsync(string movieId)
            => await _client.GetMovieAsync(int.Parse(movieId), MovieMethods.Credits | MovieMethods.AlternativeTitles);

        public async Task<TvShow?> GetTvShowAsync(string showID)
            => await _client.GetTvShowAsync(int.Parse(showID), TvShowMethods.Credits | TvShowMethods.AlternativeTitles);
    }
}