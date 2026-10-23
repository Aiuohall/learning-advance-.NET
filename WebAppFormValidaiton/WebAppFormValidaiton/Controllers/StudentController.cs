using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppFormValidaiton.Models;

namespace WebAppFormValidaiton.Controllers
{
    public class StudentController : Controller
    {
        Student student;

        public StudentController()
        {
            this.student = new Student() { Id = 100, Name = "Bruce", BloodGroup = "B+" };
        }

        public IActionResult Index()
        {
            return View(new Student());
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                return Content("Data Saved");
            }
            else
                return View(s);
        }
    }
}