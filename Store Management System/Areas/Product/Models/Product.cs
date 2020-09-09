using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.Product.Models
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Product Id is mendatory.")]
        public Int64 Product_Id { get; set; }

        [Required(ErrorMessage = "Product name is mendatory.")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage = "Product brand name is mendatory.")]
        public string Brand_Name { get; set; }

        [Required(ErrorMessage = "Product quantity is mendatory.")]
        public Int64 Product_Quantity { get; set; }

        [Required(ErrorMessage = "Product price is mendatory.")]
        public Int64 Product_Price { get; set; }
    }
}
