﻿// <auto-generated />
using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    [DbContext(typeof(ClassicModelDbContext))]
    [Migration("20240305222018_eduversion3")]
    partial class eduversion3
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
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MSRP")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProductLineeProductLine")
                        .IsRequired()
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

                    b.HasIndex("ProductLineeProductLine");

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

            modelBuilder.Entity("DAM2_M06_UF4_Activity_2_Code_First.MODEL.Product", b =>
                {
                    b.HasOne("DAM2_M06_UF4_Activity_2_Code_First.MODEL.ProductLines", "ProductLinee")
                        .WithMany("Products")
                        .HasForeignKey("ProductLineeProductLine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
