using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EatForHealth.DBContext;
using System.Linq;

namespace EatForHealth.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            using (DBContext.DBEatForHealth db = new DBContext.DBEatForHealth())
            {
                var m = db.Users.ToList();
                return View(m);
            }
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}