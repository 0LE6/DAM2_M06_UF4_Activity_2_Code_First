using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerNumber1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeNumber1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerNumber1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_EmployeeNumber1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerNumber1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EmployeeNumber1",
                table: "Order");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerNumber",
                table: "Order",
                column: "CustomerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeNumber",
                table: "Order",
                column: "EmployeeNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerNumber",
                table: "Order",
                column: "CustomerNumber",
                principalTable: "Customers",
                principalColumn: "CustomerNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeNumber",
                table: "Order",
                column: "EmployeeNumber",
                principalTable: "Employee",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerNumber",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeNumber",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerNumber",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_EmployeeNumber",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "CustomerNumber1",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNumber1",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerNumber1",
                table: "Order",
                column: "CustomerNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeNumber1",
                table: "Order",
                column: "EmployeeNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerNumber1",
                table: "Order",
                column: "CustomerNumber1",
                principalTable: "Customers",
                principalColumn: "CustomerNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeNumber1",
                table: "Order",
                column: "EmployeeNumber1",
                principalTable: "Employee",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
