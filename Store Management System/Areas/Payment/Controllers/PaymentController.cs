using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Payment.Models;
using Store_Management_System.Areas.Payment.ViewModel;
using Store_Management_System.DataBase;

namespace Store_Management_System.Controllers
{
    [Area("Payment")]
    public class PaymentController : Controller
    {
        private readonly DataContext db;
        public PaymentController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewPayment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewPayment(Payment a)
        {
            if (ModelState.IsValid)
            {
                Payment t = new Payment();
                {
                    t.Payment_Id = a.Payment_Id;
                    t.Date = a.Date;
                    t.Payment_Type = a.Payment_Type;
                    t.No_Of_Items = a.No_Of_Items;
                    t.Percentage_Of_Vat = a.Percentage_Of_Vat;
                    t.Amount_Of_Vat = a.Amount_Of_Vat;
                    t.Total_Cost = a.Total_Cost;
                    t.P_Id = a.P_Id;
                    t.E_Id = a.E_Id;
                    t.C_Id = a.C_Id;
                };
                db.Payment.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Payment Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewPaymentList");
        }

        public IActionResult EditPayment(Int64 Id)
        {
            var l = db.Payment.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditPayment(Payment a)
        {
            if (ModelState.IsValid)
            {
                Payment t = new Payment();
                t.Payment_Id = a.Payment_Id;
                t.Date = a.Date;
                t.Payment_Type = a.Payment_Type;
                t.No_Of_Items = a.No_Of_Items;
                t.Percentage_Of_Vat = a.Percentage_Of_Vat;
                t.Amount_Of_Vat = a.Amount_Of_Vat;
                t.Total_Cost = a.Total_Cost;
                t.P_Id = a.P_Id;
                t.E_Id = a.E_Id;
                t.C_Id = a.C_Id;
                db.Payment.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewPaymentList");
        }

        public IActionResult DeletePayment(Int64 Id)
        {
            var l = db.Payment.Find(Id);
            db.Payment.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult PaymentList()
        {
            var dbo = db.Payment;
            var i = new List<Payment>();
            foreach (var a in dbo)
            {
                Payment t = new Payment();
                t.Payment_Id = a.Payment_Id;
                t.Date = a.Date;
                t.Payment_Type = a.Payment_Type;
                t.No_Of_Items = a.No_Of_Items;
                t.Percentage_Of_Vat = a.Percentage_Of_Vat;
                t.Amount_Of_Vat = a.Amount_Of_Vat;
                t.Total_Cost = a.Total_Cost;
                t.P_Id = a.P_Id;
                t.E_Id = a.E_Id;
                t.C_Id = a.C_Id;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewPaymentList()
        {
            var dbo = db.Payment;
            var i = new List<Payment>();
            foreach (var a in dbo)
            {
                Payment t = new Payment();
                t.Payment_Id = a.Payment_Id;
                t.Date = a.Date;
                t.Payment_Type = a.Payment_Type;
                t.No_Of_Items = a.No_Of_Items;
                t.Percentage_Of_Vat = a.Percentage_Of_Vat;
                t.Amount_Of_Vat = a.Amount_Of_Vat;
                t.Total_Cost = a.Total_Cost;
                t.P_Id = a.P_Id;
                t.E_Id = a.E_Id;
                t.C_Id = a.C_Id;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult PaymentDetails(Int64 Id)
        {
            var k = db.Payment.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Payment.Find(Id);
            return View(k);
        }

        public IActionResult Receipt()
        {
            var a = db.Payment.ToList();
            var b = db.Product.ToList();
            var c = db.Employee.ToList();
            var d = db.Customer.ToList();
            var i = new List<PaymentVM>();
            var query = (from pay in a
                         join pro in b on pay.P_Id equals pro.Product_Id
                         join emp in c on pay.E_Id equals emp.Employee_Id
                         join cus in d on pay.C_Id equals cus.Customer_Id
                         select new
                         {
                             Payment_Id = pay.Payment_Id,
                             Date = pay.Date,
                             Payment_Type = pay.Payment_Type,
                             No_Of_Items = pay.No_Of_Items,
                             Percentage_Of_Vat = pay.Percentage_Of_Vat,
                             Amount_Of_Vat = pay.Amount_Of_Vat,
                             Total_Cost = pay.Total_Cost,
                             Product_Name = pro.Product_Name,
                             Brand_Name = pro.Brand_Name,
                             Product_Quantity = pro.Product_Quantity,
                             Product_Price = pro.Product_Price,
                             Employee_Name = emp.Employee_Name,
                             Customer_Name = cus.Customer_Name
                         });
            foreach (var item in query)
            {
                PaymentVM p = new PaymentVM();
                p.Payment_Id = item.Payment_Id;
                p.Date = item.Date;
                p.Payment_Type = item.Payment_Type;
                p.No_Of_Items = item.No_Of_Items;
                p.Percentage_Of_Vat = item.Percentage_Of_Vat;
                p.Amount_Of_Vat = item.Amount_Of_Vat;
                p.Total_Cost = item.Total_Cost;
                p.Product_Name = item.Product_Name;
                p.Brand_Name = item.Brand_Name;
                p.Product_Quantity = item.Product_Quantity;
                p.Product_Price = item.Product_Price;
                p.Employee_Name = item.Employee_Name;
                p.Customer_Name = item.Customer_Name;
                i.Add(p);
            }
            return View(i);
        }
    }
}
