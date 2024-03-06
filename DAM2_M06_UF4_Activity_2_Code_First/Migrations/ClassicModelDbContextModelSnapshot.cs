﻿// <auto-generated />
using System;
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    [DbContext(typeof(ClassicModelDbContext))]
    partial class ClassicModelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<int?>("SalesRepEmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("CustomerNumber");

                    b.HasIndex("SalesRepEmployeeNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", b =>
                {
                    b.Property<int>("EmployeeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("OfficeCode")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.HasKey("EmployeeNumber");

                    b.HasIndex("OfficeCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Office", b =>
                {
                    b.Property<string>("OfficeCode")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Territory")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.HasKey("OfficeCode");

                    b.ToTable("Offices");
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

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.HasKey("OrderNumber");

                    b.HasIndex("CustomerNumber");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.OrderDetail", b =>
                {
                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4");

                    b.Property<int>("OrderLineNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceEach")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int");

                    b.HasKey("OrderNumber", "ProductCode");

                    b.HasIndex("ProductCode");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Payment", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<string>("CheckNumber")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CustomerNumber", "CheckNumber");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("MSRP")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductLine")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(70) CHARACTER SET utf8mb4")
                        .HasMaxLength(70);

                    b.Property<string>("ProductScale")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("ProductVendor")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductCode");

                    b.HasIndex("ProductLine");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.ProductLine", b =>
                {
                    b.Property<string>("ProductLineCode")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("HtmlDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("TextDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(4000);

                    b.HasKey("ProductLineCode");

                    b.ToTable("ProductLines");
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", "SalesRep")
                        .WithMany("Customers")
                        .HasForeignKey("SalesRepEmployeeNumber")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Employee", "Manager")
                        .WithMany("Subordinates")
                        .HasForeignKey("ReportsTo")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Order", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.OrderDetail", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Payment", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.ProductLine", "ProductLineDetails")
                        .WithMany("Products")
                        .HasForeignKey("ProductLine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
