using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloAmsMVC.Models;

namespace HelloAmsMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Everest" };
            return View(movie);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}