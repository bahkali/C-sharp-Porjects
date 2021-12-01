using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace webEFcodeFirst.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [MaxLength(50)]
        public string ClassName { get; set; }

    }
}