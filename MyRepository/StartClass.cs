using System;
using System.Diagnostics;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRepository.Object;

namespace MyRepository
{
    class StartClass
    {
        static void Main()
        {
            Debug.WriteLine("This is a test");
            Movie movie1 = new Movie("Batman","Warner");
            Movie movie2 = new Movie("SuperMan", "Universal");
            List<Movie> movieList = new List<Movie>();
            movieList.Add(movie2);
            movieList.Add(movie1);
            var result = movieList.OrderBy(movie => movie.Title);
            Debug.WriteLine(result.First());
        }
    }
}
