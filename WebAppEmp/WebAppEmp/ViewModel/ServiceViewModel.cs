using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEmp.Models;

namespace WebAppEmp.ViewModel
{
    public class ServiceViewModel
    {
        public Employee Employees { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
