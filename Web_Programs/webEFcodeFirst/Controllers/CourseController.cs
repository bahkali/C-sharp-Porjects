using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webEFcodeFirst.Models;

namespace webEFcodeFirst.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext db = new SchoolContext();
        // GET: CourseController
        public ActionResult Index()
        {
            var courses = new List<Course>();
            courses = db.Courses.ToList();
            return View(courses);
        }

       
        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
           db.Courses.Add(course);
           db.SaveChanges();
           return RedirectToAction(nameof(Index));
            
        }

        // GET: CourseController/Edit/5
        
        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
