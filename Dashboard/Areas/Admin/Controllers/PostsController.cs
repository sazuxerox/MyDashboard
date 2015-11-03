using System.Linq;
using System.Web.Mvc;
using Dashboard.Areas.Admin.ViewModels;
using Dashboard.Models;
using NHibernate.Linq;
using Dashboard.Infrastructure;

namespace Dashboard.Areas.Admin.Controllers
{
    //
    // GET: /Admin/Posts/
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        private const int PostsPerPage = 5; 
        public ActionResult Index(int page = 1)
        {
            var totalPostCount = Database.Session.Query<Post>().Count();

            var currentPostPage = Database.Session.Query<Post>()
                .OrderByDescending(c => c.CreatedAt)
                .Skip((page - 1)*PostsPerPage)
                .Take(PostsPerPage)
                .ToList();

            return View(new PostsIndex
            {
               Posts = new PagedData<Post>(currentPostPage, totalPostCount,page,PostsPerPage)
            });
        }
	}
}