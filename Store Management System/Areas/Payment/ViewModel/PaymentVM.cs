using System;
using System.ComponentModel.DataAnnotations;

namespace Store_Management_System.Areas.Payment.ViewModel
{
    public class PaymentVM
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
        public Int64 Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Brand_Name { get; set; }
        public Int64 Product_Quantity { get; set; }
        public Int64 Product_Price { get; set; }
        public Int64 Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public Int64 Customer_Id { get; set; }
        public string Customer_Name { get; set; }
    }
}
