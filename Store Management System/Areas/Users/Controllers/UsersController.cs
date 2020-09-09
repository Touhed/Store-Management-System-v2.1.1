using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Users.Models;
using Store_Management_System.DataBase;
using Store_Management_System.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store_Management_System.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        private readonly DataContext db;
        public UsersController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Login Methode Start

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Login(Users model)
        {
            var user = db.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
            if (!ModelState.IsValid && user != null)
            {
                string username = user.FirstName + user.LastName;

                HttpContext.Session.GetString("UserName");

                if (user.UserType.Equals("Admin"))
                {
                    return RedirectToAction("AdminPanel", "Users", new { UserName = username });
                }
                else if (user.UserType.Equals("Employee"))
                {
                    return RedirectToAction("EmployeePanel", "Employee", new { UserName = username });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Logout()
        {
            ViewBag.Controller = ControllerContext.RouteData.Values["Controller"].ToString();
            HttpContext.Session.SetString("Users", "Expired");
            return RedirectToAction("Login", "Users");
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUserAccount(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Add(c);
                db.SaveChanges();
                ViewBag.Success = "User Account Created Successfully.";
                ModelState.Clear();
            }
            return View();
            //return RedirectToAction("ViewUserList");
        }
        public IActionResult CreateUserAccount()
        {
            return View();
        }

        public IActionResult UserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewUserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult UserDetails(Int64 Id)
        {
            var i = db.Users.Find(Id);
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        public IActionResult EditUserDetails(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditUserDetails(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewUserList");
        }

        public IActionResult DeleteUserData(Int64 Id)
        {
            var l = db.Users.Find(Id);
            db.Users.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public IActionResult Login(Users model)
        //{
        //    var i = db.Users.Where(x => x.UserId == model.UserId && x.Password == model.Password).FirstOrDefault();
        //    if (!ModelState.IsValid && i == null)
        //    {
        //        ViewBag.Login = "Data Does not exist";
        //        return RedirectToAction("Login");
        //    }
        //    else
        //    {
        //        ViewBag.Login = "Data Found";
        //        return RedirectToAction(ViewBag.Action = "Index");
        //    }
        //}
    }
}