using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public static class Hold
    {
        //Here we create a new list to store the movie information in
        private static List<MovieResponse> movies = new List<MovieResponse>();

        public static IEnumerable<MovieResponse> Movies => movies;

        //This method will use a parameter generated in our movie response model and append that information to our created list
        public static void AddMovie(MovieResponse movie)
        {
            movies.Add(movie);
        }
    }
}
