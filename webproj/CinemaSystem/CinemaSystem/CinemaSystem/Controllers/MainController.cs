using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        CinemaEntities2 db = new CinemaEntities2();
        public ActionResult Index()
        {
            var movie = db.Movies.ToList();
            return View(movie);
        }
    }
}