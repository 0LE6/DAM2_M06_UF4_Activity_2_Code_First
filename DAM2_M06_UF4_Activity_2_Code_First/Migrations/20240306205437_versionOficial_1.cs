using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class versionOficial_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ProductLineCode = table.Column<string>(maxLength: 50, nullable: false),
                    TextDescription = table.Column<string>(maxLength: 4000, nullable: false),
                    HtmlDescription = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ProductLineCode);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<string>(maxLength: 15, nullable: false),
                    ProductName = table.Column<string>(maxLength: 70, nullable: false),
                    ProductLine = table.Column<string>(maxLength: 50, nullable: false),
                    ProductScale = table.Column<string>(maxLength: 10, nullable: false),
                    ProductVendor = table.Column<string>(maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(nullable: false),
                    QuantityInStock = table.Column<int>(nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    MSRP = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductCode);
                    table.ForeignKey(
                        name: "FK_Products_ProductLines_ProductLine",
                        column: x => x.ProductLine,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLineCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLine",
                table: "Products",
                column: "ProductLine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductLines");
        }
    }
}
