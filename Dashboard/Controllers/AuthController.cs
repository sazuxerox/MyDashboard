using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Dashboard.Models;
using Dashboard.ViewModels;
using NHibernate.Linq;

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
            var user = Database.Session.Query<User>().FirstOrDefault(u => u.Username == form.Username);

            if (user == null)
                Dashboard.Models.User.FakeHash();

            if(user == null || !user.CheckPassword(form.Password))
               ModelState.AddModelError("Username", "Username or password is incorrect");

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            if (user != null) FormsAuthentication.SetAuthCookie(user.Username, true);

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