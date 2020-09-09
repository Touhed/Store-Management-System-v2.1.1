using System;
using System.Collections.Generic;
using Store_Management_System.Areas.UserRole.Models;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.DataBase;

namespace Store_Management_System.Controllers
{
    [Area("UserRole")]
    public class UserRoleController : Controller
    {
        private readonly DataContext db;
        public UserRoleController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewUserRole(UserRole a)
        {
            if (ModelState.IsValid)
            {
                UserRole t = new UserRole();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                db.UserRole.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewUserRoleList");
        }
        public IActionResult AddNewUserRole()
        {
            return View();
        }

        public IActionResult UserRoleList()
        {
            var bci = db.UserRole;
            var i = new List<UserRole>();
            foreach (var a in bci)
            {
                UserRole t = new UserRole();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewUserRoleList()
        {
            var bci = db.UserRole;
            var i = new List<UserRole>();
            foreach (var a in bci)
            {
                UserRole t = new UserRole();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult UserRoleDetails(Int64 Id)
        {
            var j = db.UserRole.Find(Id);
            return View(j);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.UserRole.Find(Id);
            return View(l);
        }


        public IActionResult EditUserRole(Int64 Id)
        {
            var l = db.UserRole.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditUserRole(UserRole a)
        {
            if (ModelState.IsValid)
            {
                UserRole t = new UserRole();
                t.UserId = a.UserId;
                t.UserType = a.UserType;
                db.UserRole.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewUserRoleList");
        }
        
        public IActionResult DeleteUserRole(Int64 Id)
        {
            var l = db.UserRole.Find(Id);
            db.UserRole.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}
