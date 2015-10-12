using System.Web.Mvc;

namespace Dashboard.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/
        public ActionResult Index()
        {
            return View();
        }
	}
}