using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Areas.Payment.Models
{
    public class Payment
    {
        [Key]
        [Required(ErrorMessage = "Payment Id is mendatory.")]
        public Int64 Payment_Id { get; set; }
        public DateTime Date { get; set; }
        public string Payment_Type { get; set; }
        public Int64 No_Of_Items { get; set; }
        public Int64 Percentage_Of_Vat { get; set; }
        public Int64 Amount_Of_Vat { get; set; }
        public Int64 Total_Cost { get; set; }
        public Int64 E_Id { get; set; }
        public Int64 C_Id { get; set; }
        public Int64 P_Id { get; set; }
    }
}
