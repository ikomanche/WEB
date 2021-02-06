using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    public class vipSaloonController : Controller
    {
        // GET: vipSaloon
        CinemaEntities2 db = new CinemaEntities2();
        public ActionResult Index()
        {
            var vip = db.Saloon.ToList();
            return View(vip);
        }
    }
}