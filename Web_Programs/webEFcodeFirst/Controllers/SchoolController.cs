using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webEFcodeFirst.Models;

namespace webEFcodeFirst.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public IActionResult Index()
        {
            var students = new List<Student>();
            
            students = db.Students.ToList();
            
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            
            db.Students.Add(student);
            db.SaveChanges();

            return RedirectToAction("Index", "School");
        }
    }
}
