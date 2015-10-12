using System.Web.Mvc;
using System.Web.Security;
using Dashboard.ViewModels;

namespace Dashboard.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                
            });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            FormsAuthentication.SetAuthCookie(form.Username, true);

            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToRoute("Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}