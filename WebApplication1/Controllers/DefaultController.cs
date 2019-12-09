using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.name = "bhavana";
            obj.Id = 1;
            
            return View(obj);

        }

    }
}