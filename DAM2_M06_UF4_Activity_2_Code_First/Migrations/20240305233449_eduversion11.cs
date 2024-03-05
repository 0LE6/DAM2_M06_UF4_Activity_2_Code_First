using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_EMPLOYEES_EmployeeNumber",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_EMPLOYEES_EmployeeNumber",
                table: "Order");

            migrationBuilder.DropTable(
                name: "EMPLOYEES");

            migrationBuilder.DropIndex(
                name: "IX_Order_EmployeeNumber",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Customers_EmployeeNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeNumber",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNumber",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EMPLOYEES",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Extension = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    JobTitle = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    OfficeCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEES", x => x.EmployeeNumber);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeNumber",
                table: "Order",
                column: "EmployeeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeNumber",
                table: "Customers",
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
        }
    }
}
