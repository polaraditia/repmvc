using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloAmsMVC.Models;
using HelloAmsMVC.ViewModels;

namespace HelloAmsMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Everest" };
            var customers = new List<Customer>()
            {
                new Customer() { FullName = "Aditia"},
                new Customer() { FullName = "Budi"},
                new Customer() { FullName = "Danu"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Movies/ByReleaseDate
        [Route("movies/byreleasedate/{year}/{month}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            if (!year.HasValue) year = DateTime.Now.Year;
            if (!month.HasValue) month = DateTime.Now.Month;

            return Content(year.Value + "/" + month.Value);
            //return View();
        }
    }
}