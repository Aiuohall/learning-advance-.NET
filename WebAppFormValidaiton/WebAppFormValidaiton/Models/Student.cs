using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFormValidaiton.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please Fill the Name Field")]
        public string Name { get; set; }

        [Display(Name = "Student's Blood Group")]
        public string BloodGroup { get; set; }

        public string Password { get; set; }

        [EmailAddress]
        [Display(Name ="Email Address")]
        public string Email { get; set; }
    }
}
