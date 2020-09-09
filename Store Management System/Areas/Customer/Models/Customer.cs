using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.Customer.Models
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "Customer Id is mendatory.")]
        public Int64 Customer_Id { get; set; }

        [Required(ErrorMessage = "Customer name is mendatory.")]
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Contact { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Scary Email.")]
        public string Customer_Email { get; set; }
    }
}
