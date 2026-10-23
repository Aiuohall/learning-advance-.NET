using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App1WF.Models;

namespace App1WF.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Test()
        {
            return Content("Hello Test Data");
        }

        public ActionResult Method2()
        {
            return Content("Method2");
        }

        public ActionResult MovieData()
        {
            var movie = new Movie()
            {
                Id = 1,
                Title = "Argo",
                Income = 346
            };

            var data = movie.Id + "\n" + movie.Title + "\n" + movie.Income;
            return Content(data);
        }
    }
}