using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employee_EmployeeNumber",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeNumber",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLine_ProductLines",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLine",
                table: "ProductLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "ProductLine",
                newName: "ProductLines");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "EMPLOYEES");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines",
                column: "ProductLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMPLOYEES",
                table: "EMPLOYEES",
                column: "EmployeeNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_EMPLOYEES_EmployeeNumber",
                table: "Customers",
                column: "EmployeeNumber",
                principalTable: "EMPLOYEES",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_EMPLOYEES_EmployeeNumber",
                table: "Order",
                column: "EmployeeNumber",
                principalTable: "EMPLOYEES",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products",
                column: "ProductLines",
                principalTable: "ProductLines",
                principalColumn: "ProductLines",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_EMPLOYEES_EmployeeNumber",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_EMPLOYEES_EmployeeNumber",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMPLOYEES",
                table: "EMPLOYEES");

            migrationBuilder.RenameTable(
                name: "ProductLines",
                newName: "ProductLine");

            migrationBuilder.RenameTable(
                name: "EMPLOYEES",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLine",
                table: "ProductLine",
                column: "ProductLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employee_EmployeeNumber",
                table: "Customers",
                column: "EmployeeNumber",
                principalTable: "Employee",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeNumber",
                table: "Order",
                column: "EmployeeNumber",
                principalTable: "Employee",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLine_ProductLines",
                table: "Products",
                column: "ProductLines",
                principalTable: "ProductLine",
                principalColumn: "ProductLines",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
