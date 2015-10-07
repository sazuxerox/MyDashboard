using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Admin/Posts/
        public ActionResult Index()
        {
            return Content("ADMIN POSTS");
        }
	}
}