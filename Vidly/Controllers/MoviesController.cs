using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Yüü Yüü Hakusho!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Hitsugaya" },
                new Customer { Name = "Renji" },
                new Customer { Name = "Minamino" },
                new Customer { Name = "Danna" }
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