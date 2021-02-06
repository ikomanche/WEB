using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaSystem.Models.Entity;

namespace CinemaSystem.Controllers
{
    public class UserController : Controller
    {
        CinemaEntities2 db = new CinemaEntities2();
        // GET: User
        public ActionResult Index()
        {
            var usr = db.UserInfo.ToList();
            return View(usr);
        }

        [HttpGet]
        public ActionResult AddUser()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserInfo p1)
        {
            db.UserInfo.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}