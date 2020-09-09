using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Employee.Models;
using Store_Management_System.DataBase;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store_Management_System.Controllers
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        private readonly DataContext db;
        public EmployeeController(DataContext x)
        {
            db = x;
        }
        public IActionResult EmployeePanel()
        {
            return View();
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(Employee a)
        {
            if (ModelState.IsValid)
            {
                Employee t = new Employee();
                t.Employee_Id = a.Employee_Id;
                t.Employee_Name = a.Employee_Name;
                t.Employee_Address = a.Employee_Address;
                t.Employee_Contact = a.Employee_Contact;
                t.Employee_Email = a.Employee_Email;
                db.Employee.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Employee Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewEmployeeList");
        }

        public IActionResult EditEmployee(Int64 Id)
        {
            var l = db.Employee.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditEmployee(Employee a)
        {
            if (ModelState.IsValid)
            {
                Employee t = new Employee();
                t.Employee_Id = a.Employee_Id;
                t.Employee_Name = a.Employee_Name;
                t.Employee_Address = a.Employee_Address;
                t.Employee_Contact = a.Employee_Contact;
                t.Employee_Email = a.Employee_Email;
                db.Employee.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewEmployeeList");
        }

        public IActionResult DeleteEmployee(Int64 Id)
        {
            var l = db.Employee.Find(Id);
            db.Employee.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult EmployeeList()
        {
            var dbo = db.Employee;
            var i = new List<Employee>();
            foreach (var a in dbo)
            {
                Employee t = new Employee();
                t.Employee_Id = a.Employee_Id;
                t.Employee_Name = a.Employee_Name;
                t.Employee_Address = a.Employee_Address;
                t.Employee_Contact = a.Employee_Contact;
                t.Employee_Email = a.Employee_Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewEmployeeList()
        {
            var dbo = db.Employee;
            var i = new List<Employee>();
            foreach (var a in dbo)
            {
                Employee t = new Employee();
                t.Employee_Id = a.Employee_Id;
                t.Employee_Name = a.Employee_Name;
                t.Employee_Address = a.Employee_Address;
                t.Employee_Contact = a.Employee_Contact;
                t.Employee_Email = a.Employee_Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult EmployeeDetails(Int64 Id)
        {
            var k = db.Employee.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Employee.Find(Id);
            return View(k);
        }
    }
}
