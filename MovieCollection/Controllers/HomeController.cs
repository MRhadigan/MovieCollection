using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeModel model = new HomeModel(Movies(), Shows());

            return View(model);
        }

        public List<Movie> Movies()
        {
            List<Movie> movieList = new List<Movie>();
            // add using the parameters in the Movie class
            movieList.Add(new Movie { Id = 1, Title = "The Godfather", Genre = "Drama", YearMade = "1972", Director = "Francis Ford Coppola", Description = "Best mob movie ever made!" });
            // add using the constructor in the Movie class
            movieList.Add(new Movie(2, "Waiting...", "Comedy", "2005", "Rob McKittrick", "Movie about working in a restaurant."));
            movieList.Add(new Movie(3, "Half Baked", "Comedy", "1998", "Tamra Davis", "Movie about smoking weed"));
            movieList.Add(new Movie(4, "The Mighty Ducks", "Disney", "1992", "Stephen Herek", "Disney Hockey movie"));
            movieList.Add(new Movie(5, "Evil Dead", "Horror", "2013", "Fede Alvarez", "Remake of the original Evil Dead"));


            return movieList;

            //List<Movie> movies = new List<Movie>
            //{
            //new Movie
            //{
            //    Id = 1,
            //    Title = "The Godfather",
            //    Genre = "Drama",
            //    YearMade = "1972",
            //    Director = "Francis Ford Coppola",
            //    Description = "Best mob movie ever made!"
            //},
            //new Movie
            //    {
            //        Id = 3,
            //        Title = "Waiting...",
            //        Genre = "Comedy",
            //        YearMade = "2005",
            //        Director = "Rob McKittrick",
            //        Description = "Movie about working in a restaurant."
            //    },
            //    new Movie
            //    {
            //        Id = 4,
            //        Title = "The Mighty Ducks",
            //        Genre = "Disney",
            //        YearMade = "1992",
            //        Director = "Stephen Herek",
            //        Description = "A kids hockey team."
            //    }
            //};


            //movieList.AddRange(new HomeModel { 1, "The Godfather", "Drama", "1972", "Francis Ford Coppola", "Best mob movie ever made!" });




        //    List<HomeModel> movieList = new List<HomeModel> (1, "The Godfather", "Drama", "1972", "Francis Ford Coppola", "Best mob movie ever made!")
        //    {
        //    },

        //};
        //    return movieList;
        }

        public List<Show> Shows()
        {
            List<Show> showList = new List<Show>
            {
            new Show
            {
                Id = 2,
                Title = "The Simpsons",
                Genre = "Comedy",
                YearsMade = "1989 - Present",
                Creator = "Matt Groening",
                Description = "Best Show Ever!"
            },
            new Show
            {
                Id = 5,
                Title = "South Park",
                Genre = "Comedy",
                YearsMade = "1997 - Present",
                Creator = "Trey Parker & Matt Stone",
                Description = "Very close to the best animated show."
            }
            };
            return showList;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
