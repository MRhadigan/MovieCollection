using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class HomeModel
    {
        public List<Movie> Movies { get; set; }

        public List<Show> Shows { get; set; }


        public HomeModel(List<Movie> movies, List<Show> shows)
        {
            this.Movies = movies;
            this.Shows = shows;

        }
    }
}
