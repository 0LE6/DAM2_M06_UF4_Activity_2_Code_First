﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class olegversion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLine1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLine1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLine1",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductLines",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLines",
                table: "Products",
                column: "ProductLines");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products",
                column: "ProductLines",
                principalTable: "ProductLines",
                principalColumn: "ProductLine",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLines",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLines",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductLine1",
                table: "Products",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLine1",
                table: "Products",
                column: "ProductLine1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLine1",
                table: "Products",
                column: "ProductLine1",
                principalTable: "ProductLines",
                principalColumn: "ProductLine",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
