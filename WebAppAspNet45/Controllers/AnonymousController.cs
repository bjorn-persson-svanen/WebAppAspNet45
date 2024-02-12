using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAspNet45.Controllers
{
    [AllowAnonymous]
    public class AnonymousController : Controller
    {
        // GET: Anonymous
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Message = "This is from controller :-P";
            return View();
        }
    }
}