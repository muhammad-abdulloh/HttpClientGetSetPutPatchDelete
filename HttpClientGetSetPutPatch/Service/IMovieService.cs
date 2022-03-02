using HttpClientGetSetPutPatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientGetSetPutPatch.Service
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMoviesAsync(long id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie> SetImageAsync(long id, string imageUrl);
        Task<byte[]> GetImageAsync(long id);
    }
}
