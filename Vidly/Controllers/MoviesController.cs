using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Sun Tzu war art"},
                new Movie {Id = 2, Name = "Enter the Dragon"}
            };
        }

        // GET: Movies/Random
            public ActionResult Random()
            {
                var movie = new Movie()
                {
                    Name = "Last Soldier Alive"
                };

                var customers = new List<Customer>
                {
                    new Customer {Name = "Hiei Jaganshi"},
                    new Customer {Name = "Kurama Youko"}
                };

                var viewModel = new RandomMovieViewModel
                {
                    Movie = movie,
                    Customer = customers
                };

                return View(viewModel);
            }
        
    }
}