using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstDockerWebProject.Controllers
{
    public class MovieController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
    }
}