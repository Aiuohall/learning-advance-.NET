using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App1WF.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Income { get; set; }

        //public Movie(int id, string title, double income)
        //{
        //    this.Id = id;
        //    this.Title = title;
        //    this.Income = income;
        //}
    }
}