using HttpClientGetSetPutPatch.Models;
using HttpClientGetSetPutPatch.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientGetSetPutPatch
{
    internal class Program
    {
        private static IMovieService _movieService = new MovieService();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Posting ... ");

            var movie = await _movieService.CreateMovieAsync(
                new Movie
                {
                    Title = "Corri o'rganish kerak",
                    Description = "Core bu dasturlash ma'nosi",
                    Image = "Bu link",
                    Author = new Author
                    {
                        FirstName = "Muhammad Abdulloh",
                        LastName = "Komilov"
                    }
                });
            Console.WriteLine("Downloading ... ");

            var movies = await _movieService.GetAllMoviesAsync();
            foreach (var item in movies)
            {
                Console.WriteLine(item.Title + " - " + item.Author.FirstName);
            }
            HttpClient client = new HttpClient();
            
        }
    }
}
