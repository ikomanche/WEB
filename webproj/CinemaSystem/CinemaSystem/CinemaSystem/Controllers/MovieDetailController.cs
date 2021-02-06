using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    public class MovieDetailController : Controller
    {
        CinemaEntities2 db = new CinemaEntities2();
        // GET: MovieDetail
        public ActionResult Index(int id)
        {            
            var detail = db.Movies.Find(id);
            return View("Index", detail);            
        }
    }
}