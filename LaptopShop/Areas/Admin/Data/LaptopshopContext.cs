using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaptopShop.Areas.Admin.Models;

namespace LaptopShop.Areas.Admin.Data
{
    public class LaptopshopContext : DbContext
    {
        public LaptopshopContext(DbContextOptions<LaptopshopContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}
