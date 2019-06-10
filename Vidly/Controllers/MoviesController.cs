using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

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