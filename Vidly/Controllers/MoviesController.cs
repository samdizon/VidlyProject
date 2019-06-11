using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult Index()
        {
            return View(_context.Movies.Include(m => m.Genre).ToList());
        }

        public ActionResult Details (int id)
        {
            return View(_context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id));
        }

        public ActionResult Random()
        {
            /*var movie = GetMovies().Find(m => m.Id == 1);
            var customers = GetCustomers();
            
            return View(new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            });*/
            return View();
        }
    }
}