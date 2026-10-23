using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTask1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is student default page");
        }

        public IActionResult Details(int id)
        {
            return Content($"Student Id: {id}");
        }

        //public IActionResult Details(int id, string name)
        //{
        //    return Content($"Student Id: {id}, Students Name: {name}");
        //}

        public IActionResult M1(int month)
        {
            return Content($"Month: {month}");
        }
    }
}