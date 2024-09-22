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
        // Update a student's information (GET method to show form)
        [HttpGet]
       
// Changes from GitHub (Update method)
public ActionResult UpdateStudent(int id)
{
    var student = students.Find(s => s.Id == id);
    if (student == null)
    {
        return HttpNotFound();
    }
    return View(student);
}

        // Update student's information (POST method to save changes)
        [HttpPost]
        public ActionResult Update(Student student)
        {
            var oldstudent = students.FirstOrDefault(s => s.Id == student.Id);
            if (oldstudent == null)
            {
                return HttpNotFound();
            }
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine();
            oldstudent.Name = student.Name;
            oldstudent.RollNo = student.RollNo;
            oldstudent.Department = student.Department;

            return RedirectToAction("Index");
        }

        // Delete a student
        public ActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }

            return RedirectToAction("Index");
        }

    }
}
