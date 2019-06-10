using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                id = 1;
            return View(GetCustomers().Find(c => c.Id == id));
        }



        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer(){ Id = 1, Name = "Sam Dizon" },
                new Customer(){ Id = 2, Name = "Angel Dizon"}
            };
        }
    }
}