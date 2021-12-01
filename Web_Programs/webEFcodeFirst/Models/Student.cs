using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webEFcodeFirst.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [MaxLength(50)]
        public string StudentName { get; set; }

        public DateTime? DOB { get; set; }

        public List<Course> StudentCourses { get; set; }

    }
}
