using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    
    public class GenreController : Controller
    {
        CinemaEntities2 db = new CinemaEntities2();
        // GET: Genre
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Genres(string genre)
        {
            var gen = db.Movies.Where(g => g.genre == genre).Select(g => g);
            return View(gen);
        }        
    }
}