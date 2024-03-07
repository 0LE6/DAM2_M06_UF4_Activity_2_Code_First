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
            // empleamos el API fluent para configurar ciertos aspectos del método

            // configuracion 1-N entre product y productLine
            // La regla OnDelete(DeleteBehavior.Restrict) evita que se borre la línea de producto si se borra un producto.
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductLineDetails)
                .WithMany(pl => pl.Products)
                .HasForeignKey(p => p.ProductLine)
                .OnDelete(DeleteBehavior.Restrict);

            // config de la clave compuesta de orderNumber + productCode en la tabla OrderDetails
            modelBuilder.Entity<OrderDetail>()
               .HasKey(od => new { od.OrderNumber, od.ProductCode });

            // configuracion 1-N entre customer y order
            // La regla OnDelete(DeleteBehavior.Cascade) indica que si se borra un cliente -> sus orders tb se borran
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerNumber)
                .OnDelete(DeleteBehavior.Cascade);

            // configuracion 1-N entre employee y customer 
            // OnDelete(DeleteBehavior.Restrict) evita borrar el empleado si se elimina un cliente.
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.SalesRep)
                .WithMany(e => e.Customers)
                .HasForeignKey(c => c.SalesRepEmployeeNumber)
                .OnDelete(DeleteBehavior.Restrict);

            // config de la relacion jerarquica entre subordinados y manager
            // ReportsTo es la clave primaria del manager al que reporta un empleado
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Subordinates)
                .WithOne(s => s.Manager)
                .HasForeignKey(s => s.ReportsTo)
                .OnDelete(DeleteBehavior.Restrict);

            // configuracion 1-N entre office y employee
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeCode)
                .OnDelete(DeleteBehavior.Cascade); // TODO : si se elimina ofi, tb lso empleados, cambiar a Restrict lol

            // config de la clave compuesta de CustomerNumber + CheckNumber en la tabla Payments
            modelBuilder.Entity<Payment>()
                .HasKey(p => new { p.CustomerNumber, p.CheckNumber });
        }
    }
}
