using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Henson_Student.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FavoriteColor { get; set; }

        public Student()
        {
            StudentID = 0;
            FirstName = String.Empty;
            LastName = String.Empty;
            FavoriteColor = String.Empty;
        }
    }
}