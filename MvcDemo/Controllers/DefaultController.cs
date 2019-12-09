using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string wishes = "happy";
            ViewBag.info = wishes;
            return View();
        }
        public string Name()
        {
            return "Hello World!";
        }
        public RedirectResult GO()
        {
            return Redirect(@"D:\MVC CLASSES\MvcDemo\Views\Default\Index.cshtml");
        }
    }
}