#region "Copyright"
/***********************************************************************************
* Copyright (C) 2025  Tiago.NET
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
**********************************************************************************/
#endregion

using Aniflix.Functions;
using System.Net;
using TMDbLib.Client;
using TMDbLib.Objects.Account;
using TMDbLib.Objects.Authentication;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.TvShows;

namespace Aniflix.Contracts
{
    public class TMDBContracts
    {
        private static readonly HttpClientHandler handler = new()
        {
            Proxy = new WebProxy("socks4://45.128.133.199:1080"),
            UseProxy = true
        };

        public TMDBContracts()
        {
            var httpclient = new HttpClient(handler);
        }


        private readonly TMDbClient _client = new(GlobalVars.TMDB_KEY, true, "", null, handler)
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR",
            Timeout = TimeSpan.FromSeconds(900),
            MaxRetryCount = 5
        };
        public async Task<AccountDetails?> GetAccountDetailsAsync(string sessionId)
        {
            await _client.SetSessionInformationAsync(sessionId, SessionType.UserSession);
            var account = await _client.AccountGetDetailsAsync();

            return account;
        }

        public async Task<Movie?> GetMovieAsync(string movieId)
            => await _client.GetMovieAsync(int.Parse(movieId), MovieMethods.Credits | MovieMethods.AlternativeTitles);

        public async Task<TvShow?> GetTvShowAsync(string showID)
            => await _client.GetTvShowAsync(int.Parse(showID), TvShowMethods.Credits | TvShowMethods.AlternativeTitles);
    }
}