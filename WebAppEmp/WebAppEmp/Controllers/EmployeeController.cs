using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppEmp.Models;
using WebAppEmp.ViewModel;

namespace WebAppEmp.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        private List<Employee> empList;

        public EmployeeController()
        {
            this.empList = new List<Employee>()
            {
                new Employee {Id = 1, Name = "Bruce", Salary = 15000},
                new Employee {Id = 2, Name = "Clerk", Salary = 10000},
                new Employee {Id = 3, Name = "Diana", Salary = 12000},
                new Employee {Id = 4, Name = "Arthur", Salary = 11000}
            };
        }

        public IActionResult Index()
        {
            //Employee emp = new Employee();
            //emp.Id = 1;
            //emp.Name = "Bruce";
            //emp.Salary = 15000;

            Employee emp = new Employee
            {
                Id = 1,
                Name = "Bruce",
                Salary = 15000
            };
            return View(emp);
        }

        [Route("List")]
        public IActionResult ListEmployee()
        {
            return View(this.empList);
        }

        [Route("List/{id}")]
        public IActionResult EachEmployee(int id)
        {
            var data = empList.Where(x => x.Id == id).FirstOrDefault();

            if (data == null)
            {
                ViewData["Msg"] = "No Data Found in the list";
                ViewBag.State = false;
            }
            else
                ViewBag.State = true;

            return View(data);
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Sample()
        {
            return View("Test");
        }

        [Route("Service")]
        public IActionResult CustomerService()
        {
            Employee e = new Employee();
            e.Id = 100;
            e.Name = "CLerk";
            e.Salary = 10000;           

            Customer c1 = new Customer()
            {
                Phone = "123",
                Name = "Logan"
            };

            Customer c2 = new Customer()
            {
                Phone = "456",
                Name = "Peter"
            };

            Customer c3 = new Customer()
            {
                Phone = "789",
                Name = "Arthur"
            };

            var customerList = new List<Customer>();
            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);

            var serviceData = new ServiceViewModel();

            serviceData.Employees = e;
            serviceData.Customers = customerList;

            var flag = false;
            var count = serviceData.Customers.Count;
            if (count > 2)
                flag = true;

            ViewBag.State = flag;
            ViewBag.Count = count;

            ViewData["State"] = flag;


            return View(serviceData);
        }

        [Route("Helper")]
        public IActionResult Helper()
        {
            return View();
        }
    }
}