using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.Admin.Models
{
    public class Admin
    {
        [Key]
        public Int64 SN { get; set; }
        public Int64 AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Photo { get; set; }
    }
}
