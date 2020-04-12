using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.DB.Entities.Concrete;

namespace ECommerseProject.DB.DAL.Concrete.EntityFramework
{
    public class ECommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6NB7684\SQLEXPRESS;Database=ECommerceDB; Trusted_Connection=true");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shippers> Shippers { get; set; }

    }
}
