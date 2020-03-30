using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Henson_Employee.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewEmployee()
        {
            ViewBag.Message = "This is the portal for all new employees";
            return View();
        }

        public ActionResult EasyWay()
        {
            ViewBag.Message = "The easiest way to view information about your employees.";
            return View();
        }
    }
}