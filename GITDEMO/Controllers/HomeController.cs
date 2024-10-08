﻿using GITDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GITDEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TeacherList()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher {Id = 1, Name = "Tayyab", Subject = "Programming Fundamental", Salary = 20000},
                new Teacher {Id = 2, Name ="Adrees", Subject ="Information Security", Salary= 30000 },
                new Teacher {Id = 3, Name ="Zain", Subject ="Artificial Intelligence", Salary= 40000 },
                new Teacher {Id = 4, Name = "Tayyab", Subject = "Data Structure", Salary= 50000 },
                // Add the new teacher Detail
                new Teacher {Id = 5, Name="Rehan", Subject = "Object Oriented Progrmaming", Salary=30000}
            };
            return View(teachers);
        }

    }
       
}