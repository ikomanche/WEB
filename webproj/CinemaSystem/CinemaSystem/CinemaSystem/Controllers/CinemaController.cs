using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;
namespace CinemaSystem.Controllers
{
    public class CinemaController : Controller
    {
        CinemaEntities2 db = new CinemaEntities2();
        // GET: Cinema
        public ActionResult Index()
        {
            var cin = db.Cinemas.ToList();
            return View(cin);
        }
    }
}