using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Henson_Employee.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public Employee()
        {
            Name = "";
            CreationDate = DateTime.Now;
        }
    }
}