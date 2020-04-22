﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Participation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Courses()
        {
            ViewBag.Message = "List of courses.";

            return View();
        }

        public ActionResult Regisration()
        {
            ViewBag.Message = "Registration.";

            return View();
        }

        public ActionResult Students()
        {
            ViewBag.Message = "List of students.";

            return View();
        }
    }
}