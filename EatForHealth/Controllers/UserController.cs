using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EatForHealth.DBContext;
using EatForHealth.Models;
using EatForHealth.Utils;

namespace EatForHealth.Controllers
{
    public class UserController : Controller
    {
        private DBContext.DBEatForHealth db = new DBContext.DBEatForHealth();
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            bool isUserExists = db.Users.Where(a => a.UserName == user.UserName).Count() != 0;

            if (isUserExists)
                ModelState.AddModelError("Username", "Repeated!");

            if (!ModelState.IsValid)
            {
                return View(user);
            }

            try
            {
                String toEmail = user.Email;

                EmailSender es = new EmailSender();
                es.Send(toEmail, "Congradations!", "You have successfully registered on EatForHealth~");

                ViewBag.Result = "Email has been send.";

                ModelState.Clear();
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "User");
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                        {
                        System.Diagnostics.Trace.TraceInformation("Property: {0} Error: {1}",
                        validationError.PropertyName,
                        validationError.ErrorMessage);
                        }
                }
                throw;
             }
        }
        
        public ActionResult Register()
        {
            return View();
        }
    }
}