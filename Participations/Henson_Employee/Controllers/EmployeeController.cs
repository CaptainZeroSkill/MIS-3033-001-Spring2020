using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Henson_Employee.Models;

namespace Henson_Employee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()

        {
            Employee newEmployee = new Employee();
            newEmployee.Name = "Braden Henson";

            return View(newEmployee);
        }
    }
}