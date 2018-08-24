using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EatForHealth.DBContext;
using System.Linq;

namespace EatForHealth.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Index(string username, string password)
        {
            using (DBContext.DBEatForHealth db = new DBContext.DBEatForHealth())
            {
            }
                return View();
        }
    }
}