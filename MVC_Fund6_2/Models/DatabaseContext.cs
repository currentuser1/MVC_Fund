using System.Data.Entity;


namespace MVC_Fund6_2.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
           : base("name=DatabaseContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}