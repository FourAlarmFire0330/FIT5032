using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EatForHealth.DBContext;
using System.Linq;
using EatForHealth.Models;

namespace EatForHealth.Controllers
{
    public class RecipeController : Controller
    {
        private DBContext.EFHDbContext db = new DBContext.EFHDbContext();
        // GET: Recipe
        public ActionResult Index(Recipe recipe)
        {
            return View(db.Recipes.ToList());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            db.Recipes.Add(recipe);
            db.SaveChanges();
            return RedirectToAction("Index", "Recipe");
        }

        public ActionResult aaa()
        {
            return View();
        }
    }
}