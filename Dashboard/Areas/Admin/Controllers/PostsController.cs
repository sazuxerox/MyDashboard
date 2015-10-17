using System.Web.Mvc;
using Dashboard.Infrastructure;

namespace Dashboard.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Admin/Posts/
        [Authorize(Roles = "admin")]
        [SelectedTab("posts")]
        public ActionResult Index()
        {
            return View();
        }
	}
}