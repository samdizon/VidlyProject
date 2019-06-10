using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View(GetMovies());
        }

        public ActionResult Details (int? id)
        {
            if (id == null)
                id = 1;
            return View(GetMovies().Find(m => m.Id == id));
        }

        public ActionResult Random()
        {
            var movie = GetMovies().Find(m => m.Id == 1);
            var customers = GetCustomers();
            
            return View(new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            });
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer(){ Id = 1, Name = "Sam Dizon" },
                new Customer(){ Id = 2, Name = "Angel Dizon"}
            };
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek!"},
                new Movie {Id = 2, Name = "Wall-E"}
            };
        }
    }
}