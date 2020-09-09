using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.Employee.Models
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "Employee Id is mendatory.")]
        public Int64 Employee_Id { get; set; }

        [Required(ErrorMessage = "Employee name is mendatory.")]
        public string Employee_Name { get; set; }
        public string Employee_Address { get; set; }
        public string Employee_Contact { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Scary Email.")]
        public string Employee_Email { get; set; }
    }
}
