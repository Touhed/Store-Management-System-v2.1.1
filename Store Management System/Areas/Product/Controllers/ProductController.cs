using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Areas.Product.Models;
using Store_Management_System.DataBase;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store_Management_System.Controllers
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly DataContext db;
        public ProductController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product a)
        {
            if (ModelState.IsValid)
            {
                Product t = new Product();
                t.Product_Id = a.Product_Id;
                t.Product_Name = a.Product_Name;
                t.Brand_Name = a.Brand_Name;
                t.Product_Quantity = a.Product_Quantity;
                t.Product_Price = a.Product_Price;
                db.Product.Add(t);
                db.SaveChanges();
                ViewBag.Success = "New Product Added Successfully.";
                ModelState.Clear();
            }
            return View();
            //return Redirect("ViewProductList");
        }

        public IActionResult EditProduct(Int64 Id)
        {
            var l = db.Product.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditProduct(Product a)
        {
            if (ModelState.IsValid)
            {
                Product t = new Product();
                t.Product_Id = a.Product_Id;
                t.Product_Name = a.Product_Name;
                t.Brand_Name = a.Brand_Name;
                t.Product_Quantity = a.Product_Quantity;
                t.Product_Price = a.Product_Price;
                db.Product.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewProductList");
        }

        public IActionResult DeleteProduct(Int64 Id)
        {
            var l = db.Product.Find(Id);
            db.Product.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult ProductList()
        {
            var dbo = db.Product;
            var i = new List<Product>();
            foreach (var a in dbo)
            {
                Product t = new Product();
                t.Product_Id = a.Product_Id;
                t.Product_Name = a.Product_Name;
                t.Brand_Name = a.Brand_Name;
                t.Product_Quantity = a.Product_Quantity;
                t.Product_Price = a.Product_Price;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewProductList()
        {
            var dbo = db.Product;
            var i = new List<Product>();
            foreach (var a in dbo)
            {
                Product t = new Product();
                t.Product_Id = a.Product_Id;
                t.Product_Name = a.Product_Name;
                t.Brand_Name = a.Brand_Name;
                t.Product_Quantity = a.Product_Quantity;
                t.Product_Price = a.Product_Price;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ProductDetails(Int64 Id)
        {
            var k = db.Product.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Product.Find(Id);
            return View(k);
        }
    }
}
