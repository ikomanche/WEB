using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    public class ArtistController : Controller
    {
        CinemaEntities6 db = new CinemaEntities6();
        // GET: Artist
        public ActionResult Index(int id)
        {
            var artists = db.Artist.Where(a => a.Movie == id).Select(a => a);
            return View(artists);
        }
    }
}