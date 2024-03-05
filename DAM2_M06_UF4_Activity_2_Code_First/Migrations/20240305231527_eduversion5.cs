using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Extension = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    OfficeCode = table.Column<string>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerNumber = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: false),
                    ContactLastName = table.Column<string>(nullable: false),
                    ContactFirstName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    AdressLine1 = table.Column<string>(nullable: false),
                    AdressLine2 = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    EmployeeNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerNumber);
                    table.ForeignKey(
                        name: "FK_Customers_Employee_EmployeeNumber",
                        column: x => x.EmployeeNumber,
                        principalTable: "Employee",
                        principalColumn: "EmployeeNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    CustomerNumber = table.Column<int>(nullable: false),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    CustomerNumber1 = table.Column<int>(nullable: false),
                    EmployeeNumber1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderNumber);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerNumber1",
                        column: x => x.CustomerNumber1,
                        principalTable: "Customers",
                        principalColumn: "CustomerNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Employee_EmployeeNumber1",
                        column: x => x.EmployeeNumber1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderLineNumber = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderNumber = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(nullable: false),
                    QuantityOrdered = table.Column<int>(nullable: false),
                    PriceEach = table.Column<decimal>(nullable: false),
                    OrderLineAmount = table.Column<decimal>(nullable: false),
                    OrderNumber1 = table.Column<int>(nullable: false),
                    ProductCode1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderLineNumber);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderNumber1",
                        column: x => x.OrderNumber1,
                        principalTable: "Order",
                        principalColumn: "OrderNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductCode1",
                        column: x => x.ProductCode1,
                        principalTable: "Products",
                        principalColumn: "ProductCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLine1",
                table: "Products",
                column: "ProductLine1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeNumber",
                table: "Customers",
                column: "EmployeeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerNumber1",
                table: "Order",
                column: "CustomerNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeNumber1",
                table: "Order",
                column: "EmployeeNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderNumber1",
                table: "OrderDetails",
                column: "OrderNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode1",
                table: "OrderDetails",
                column: "ProductCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLine1",
                table: "Products",
                column: "ProductLine1",
                principalTable: "ProductLines",
                principalColumn: "ProductLine",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLine1",
                table: "Products");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLine1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLine1",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductLines",
                table: "Products",
                type: "varchar(255) CHARACTER SET utf8mb4",
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
    }
}
