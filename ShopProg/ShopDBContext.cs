using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShopProg.Classes;

namespace ShopProg
{
    internal class ShopDBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<ProductGrup> grups { get; set; }
        public DbSet<SupplierProductListItem> supplierProductListItems { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Customer> customers { get; set; }
        public ShopDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShopDB;Trusted_Connection=True;");
        }
    }
}
