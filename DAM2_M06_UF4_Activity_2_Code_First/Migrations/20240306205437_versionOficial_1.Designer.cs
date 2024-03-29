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
    [Migration("20240306205437_versionOficial_1")]
    partial class versionOficial_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
