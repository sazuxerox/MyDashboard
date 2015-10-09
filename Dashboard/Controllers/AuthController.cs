using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Dashboard.ViewModels;

namespace Dashboard.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin
            {});
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);

            if (form.Username != "sazzad")
            {
                ModelState.AddModelError("Username", "Username and password is not 20% cooler");
                return View(form);
            }
            return Content("The form is valid");
        }
    }
}