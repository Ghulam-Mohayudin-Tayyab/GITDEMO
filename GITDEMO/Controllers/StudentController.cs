using GITDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace GITDEMO.Controllers
{
    public class StudentController : Controller
    {
        // Hardcoded student list for simplicity (you can later use a database)
        public static List<Student> students = new List<Student>();

        // Action method to show form
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Action method to handle form submission
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                students.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // Action method to display the list of students
        public ActionResult Index()
        {
            return View(students);
        }
    }
}