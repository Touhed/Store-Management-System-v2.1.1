using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Customer.Models;
using Store_Management_System.DataBase;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store_Management_System.Controllers
{
    [Area("Customer")]
    public class CustomerController : Controller
    {
        private readonly DataContext db;
        public CustomerController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCustomer(Customer a)
        {
            if (ModelState.IsValid)
            {
                Customer t = new Customer();
                t.Customer_Id = a.Customer_Id;
                t.Customer_Name = a.Customer_Name;
                t.Customer_Address = a.Customer_Address;
                t.Customer_Contact = a.Customer_Contact;
                t.Customer_Email = a.Customer_Email;
                db.Customer.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Customer Added Successfully.";
                ModelState.Clear();
            }
            //return Redirect("ViewCustomerList");
            return View();
        }

        public IActionResult EditCustomer(Int64 Id)
        {
            var l = db.Customer.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditCustomer(Customer a)
        {
            if (ModelState.IsValid)
            {
                Customer t = new Customer();
                t.Customer_Id = a.Customer_Id;
                t.Customer_Name = a.Customer_Name;
                t.Customer_Address = a.Customer_Address;
                t.Customer_Contact = a.Customer_Contact;
                t.Customer_Email = a.Customer_Email;
                db.Customer.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewCustomerList");
        }

        public IActionResult DeleteCustomer(Int64 Id)
        {
            var l = db.Customer.Find(Id);
            db.Customer.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult CustomerList()
        {
            var bci = db.Customer;
            var i = new List<Customer>();
            foreach (var a in bci)
            {
                Customer t = new Customer();
                t.Customer_Id = a.Customer_Id;
                t.Customer_Name = a.Customer_Name;
                t.Customer_Address = a.Customer_Address;
                t.Customer_Contact = a.Customer_Contact;
                t.Customer_Email = a.Customer_Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewCustomerList()
        {
            var bci = db.Customer;
            var i = new List<Customer>();
            foreach (var a in bci)
            {
                Customer t = new Customer();
                t.Customer_Id = a.Customer_Id;
                t.Customer_Name = a.Customer_Name;
                t.Customer_Address = a.Customer_Address;
                t.Customer_Contact = a.Customer_Contact;
                t.Customer_Email = a.Customer_Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult CustomerDetails(Int64 Id)
        {
            var k = db.Customer.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Customer.Find(Id);
            return View(k);
        }
    }
}
