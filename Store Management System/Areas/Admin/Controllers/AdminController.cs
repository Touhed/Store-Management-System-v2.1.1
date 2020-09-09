using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Admin.Models;
using Store_Management_System.DataBase;

namespace Store_Management_System.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly DataContext db;
        public AdminController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAdmin(Admin a)
        {
            if (ModelState.IsValid)
            {
                Admin t = new Admin();
                t.SN = a.SN;
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                t.Photo = a.Photo;
                db.Admin.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Admin Added Successfully.";
                ModelState.Clear();
            }
            return Redirect("ViewAdminList");
        }
        public IActionResult AddNewAdmin()
        {
            return View();
        }

        public IActionResult EditAdmin(Int64 Id)
        {
            var l = db.Admin.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditAdmin(Admin a)
        {
            if (ModelState.IsValid)
            {
                Admin t = new Admin();
                t.SN = a.SN;
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                t.Photo = a.Photo;
                db.Admin.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewAdminList");
        }

        public IActionResult DeleteAdmin(Int64 Id)
        {
            var l = db.Admin.Find(Id);
            db.Admin.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult AdminList()
        {
            var bci = db.Admin;
            var i = new List<Admin>();
            foreach (var a in bci)
            {
                Admin t = new Admin();
                t.SN = a.SN;
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                t.Photo = a.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewAdminList()
        {
            var bci = db.Admin;
            var i = new List<Admin>();
            foreach (var a in bci)
            {
                Admin t = new Admin();
                t.SN = a.SN;
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                t.Photo = a.Photo;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult AdminDetails(Int64 Id)
        {
            var k = db.Admin.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Admin.Find(Id);
            return View(k);
        }
    }
}
