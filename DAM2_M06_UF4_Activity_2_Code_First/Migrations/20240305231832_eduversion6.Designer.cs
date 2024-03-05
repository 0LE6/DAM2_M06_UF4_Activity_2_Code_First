﻿// <auto-generated />
using System;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    [DbContext(typeof(ClassicModelDbContext))]
    [Migration("20240305231832_eduversion6")]
    partial class eduversion6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdressLine1")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AdressLine2")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CustomerNumber");

                    b.HasIndex("EmployeeNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", b =>
                {
                    b.Property<int>("EmployeeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OfficeCode")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EmployeeNumber");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Order", b =>
                {
                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<int>("CustomerNumber1")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeNumber1")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("OrderNumber");

                    b.HasIndex("CustomerNumber1");

                    b.HasIndex("EmployeeNumber1");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.OrderDetail", b =>
                {
                    b.Property<int>("OrderLineNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("OrderLineAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber1")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceEach")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductCode1")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int");

                    b.HasKey("OrderLineNumber");

                    b.HasIndex("OrderNumber1");

                    b.HasIndex("ProductCode1");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MSRP")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductLinesProductLine")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductScale")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductVendor")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductCode");

                    b.HasIndex("ProductLinesProductLine");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.ProductLines", b =>
                {
                    b.Property<string>("ProductLine")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("HtmlDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TextDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ProductLine");

                    b.ToTable("ProductLines");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", null)
                        .WithMany("Customers")
                        .HasForeignKey("EmployeeNumber");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Order", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerNumber1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeNumber1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.OrderDetail", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderNumber1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductCode1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.ProductLines", null)
                        .WithMany("Products")
                        .HasForeignKey("ProductLinesProductLine");
                });
#pragma warning restore 612, 618
        }
    }
}
