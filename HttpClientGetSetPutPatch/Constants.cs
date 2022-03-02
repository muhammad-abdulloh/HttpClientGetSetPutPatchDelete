using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientGetSetPutPatch
{
    public class Constants
    {
        public static readonly string BASE_URL = "https://uzflix.herokuapp.com/api/";
        public static readonly string MOVIE_GET_ALL = Path.Combine(BASE_URL, "Movie/GetMovies");
        public static readonly string MOVIE_POST = Path.Combine(BASE_URL, "Movie/PostMovie");
        public static readonly string MOVIE_SET_IMAGE = Path.Combine(BASE_URL, "Movie/SetImage");
        public static readonly string MOVIE_GET_IMAGE = Path.Combine(BASE_URL, "Movie/GetImage");
    }
}
