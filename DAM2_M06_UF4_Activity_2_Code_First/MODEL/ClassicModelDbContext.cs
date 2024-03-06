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
                    "Server=localhost;Database=1classicmodel;Uid=root;Pwd=\"\"");
            }
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductLine> ProductLines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OrderDetail>()
            //    .HasKey(od => new { od.OrderNumber, od.ProductCode });

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductLineDetails)
                .WithMany(pl => pl.Products)
                .HasForeignKey(p => p.ProductLine)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Subordinates)
                .WithOne(s => s.Manager)
                .HasForeignKey(s => s.ReportsTo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.SalesRep)
                .WithMany(e => e.Customers)
                .HasForeignKey(c => c.SalesRepEmployeeNumber)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderNumber, od.ProductCode });

            modelBuilder.Entity<Payment>()
                .HasKey(p => new { p.CustomerNumber, p.CheckNumber });

            // Configurar la relación entre Orders y Customers correctamente
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerNumber)
                .OnDelete(DeleteBehavior.Cascade); // o .Restrict dependiendo de las reglas de negocio

            // Asegurarse de que el campo OfficeCode en Employees esté mapeado correctamente
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeCode)
                .OnDelete(DeleteBehavior.Cascade); // o .Restrict dependiendo de las reglas de negocio


        }
    }
}
