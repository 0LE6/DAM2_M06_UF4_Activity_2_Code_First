using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class ClassicModelDbContext : DbContext
    {
        public ClassicModelDbContext() { }
        public ClassicModelDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "Server=localhost;Database=0classicmodel;Uid=root;Pwd=\"\"");
            }
        }

        //Composite key per Payments
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasKey(o => new { o.CheckNumber, o.CustomerNumber });
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductLine> ProductLines { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<Order> Orders { get; set; }

        //public virtual DbSet<Employee> Employees { get; set; }
        // public virtual DbSet<Office> Offices { get; set; }

        //public virtual DbSet<Payment> Payments { get; set; }





    }
}
