using HttpClientGetSetPutPatch.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientGetSetPutPatch.Service
{
    public class MovieService : IMovieService
    {
        private HttpClient _httpClient;

        public MovieService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Movie> CreateMovieAsync(Movie movie)
        {
            string json = JsonConvert.SerializeObject(movie);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(Constants.MOVIE_POST, content);

            string message = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Movie>(message);
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Constants.MOVIE_GET_ALL);
            string content = await response.Content.ReadAsStringAsync();  // shu joyda hamma malumotni o'qivoldik

            return JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);
        }

        public Task<byte[]> GetImageAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GetMoviesAsync(long id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Constants.MOVIE_GET_ALL);
            string content = await response.Content.ReadAsStringAsync();  // shu joyda hamma malumotni o'qivoldik

            return JsonConvert.DeserializeObject<Movie>(content);

        }

        public Task<Movie> SetImageAsync(long id, string imageUrl)
        {
            throw new NotImplementedException();
        }
    }
}
