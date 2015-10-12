using System.Web.Mvc;
using Dashboard.Infrastructure;

namespace Dashboard.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        //
        // GET: /Admin/Users/
        public ActionResult Index()
        {
            return View();
        }
	}
}