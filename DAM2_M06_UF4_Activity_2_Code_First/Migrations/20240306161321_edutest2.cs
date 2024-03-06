﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class edutest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_OrderNumber1",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductCode1",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderNumber1",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductCode1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderNumber1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductCode1",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderNumber",
                table: "OrderDetails",
                column: "OrderNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_OrderNumber",
                table: "OrderDetails",
                column: "OrderNumber",
                principalTable: "Order",
                principalColumn: "OrderNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductCode",
                table: "OrderDetails",
                column: "ProductCode",
                principalTable: "Products",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_OrderNumber",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductCode",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderNumber",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "OrderDetails",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber1",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode1",
                table: "OrderDetails",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderNumber1",
                table: "OrderDetails",
                column: "OrderNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode1",
                table: "OrderDetails",
                column: "ProductCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_OrderNumber1",
                table: "OrderDetails",
                column: "OrderNumber1",
                principalTable: "Order",
                principalColumn: "OrderNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductCode1",
                table: "OrderDetails",
                column: "ProductCode1",
                principalTable: "Products",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
