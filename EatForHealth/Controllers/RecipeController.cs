using System.Linq;
using System.Web.Mvc;
using EatForHealth.Models;
using System.Configuration;
using PagedList;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace EatForHealth.Controllers
{
    public class RecipeController : Controller
    {
        private DBContext.EFHDbContext db = new DBContext.EFHDbContext();

        // GET: Recipe, Pagination
        public ActionResult Index(int? page)
        {
            //  Get the recipe list
            var recipes = from s in db.Recipes select s;

            int pageNumber = page ?? 1;

            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);

            recipes = recipes.OrderBy(x => x.RecipeID);

            IPagedList<Recipe> pagedList = recipes.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
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

        public ActionResult Details(int id)
        {
            //  Get the Recipe
            Recipe recipe = db.Recipes.Find(id);
            //  Get the Related Comments
            var a = db.Comments.Where(c => c.RecipeID == id).Select(t => t.Comments);
            foreach(var b in a)
            {
                ViewBag.Comments = b;
            }           

            ViewBag.Content = recipe.RecipeDetails;
            ViewBag.RecipeID = recipe.RecipeID;

            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddComments(int RecipeID, string Comments)
        {
            Comment comments = new Comment();
            comments.UserID = User.Identity.GetUserId();
            comments.RecipeID = RecipeID;
            comments.Comments = Comments;
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Comments.Add(comments);
            db.SaveChanges();
            Recipe recipe = db.Recipes.Find(RecipeID);
            return RedirectToAction("Details", new { id = RecipeID });
        }
    }
}