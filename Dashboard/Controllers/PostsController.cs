using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/
        public ActionResult Index()
        {
            return Content("Hello World!");
        }
	}
}