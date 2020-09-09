using Microsoft.EntityFrameworkCore;
using Store_Management_System.Areas.Admin.Models;
using Store_Management_System.Areas.Customer.Models;
using Store_Management_System.Areas.Employee.Models;
using Store_Management_System.Areas.Payment.Models;
using Store_Management_System.Areas.Product.Models;
using Store_Management_System.Areas.UserRole.Models;
using Store_Management_System.Areas.Users.Models;

namespace Store_Management_System.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
