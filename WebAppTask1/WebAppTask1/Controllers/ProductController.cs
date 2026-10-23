using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTask1.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index of Product");
        }

        [Route("m1")]
        public IActionResult M1()
        {
            return Content("M1 of Product");
        }

        [Route("MTD2")]
        public IActionResult M2()
        {
            return Content("M2 of Product");
        }

        [Route("M3/{id:int:max(20)}")]
        public IActionResult M3(int id)
        {
            return Content($"M3 of Product {id}");
        }
    }
}