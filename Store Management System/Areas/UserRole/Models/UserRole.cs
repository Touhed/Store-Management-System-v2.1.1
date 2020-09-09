using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.UserRole.Models
{
    public class UserRole
    {
        [Key]
        public long UserId { get; set; }

        [Required(ErrorMessage = "Type is mendatory.")]
        public String UserType { get; set; }
    }
}
