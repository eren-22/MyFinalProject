using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NorthwindContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  // projenin hangi veritabanıyla ilişkili olduğunu belirttiğimiz yer.
        {
            optionsBuilder.UseSqlServer(@"Server=EREN\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;Encrypt=false");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
