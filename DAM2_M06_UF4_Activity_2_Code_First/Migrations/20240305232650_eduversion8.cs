using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLinesProductLine",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLinesProductLine",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines");

            migrationBuilder.DropColumn(
                name: "ProductLinesProductLine",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLine",
                table: "ProductLines");

            migrationBuilder.AddColumn<string>(
                name: "ProductLines",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductLines",
                table: "ProductLines",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines",
                column: "ProductLines");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLines",
                table: "Products",
                column: "ProductLines");

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
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLines",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines");

            migrationBuilder.DropColumn(
                name: "ProductLines",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLines",
                table: "ProductLines");

            migrationBuilder.AddColumn<string>(
                name: "ProductLinesProductLine",
                table: "Products",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductLine",
                table: "ProductLines",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines",
                column: "ProductLine");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLinesProductLine",
                table: "Products",
                column: "ProductLinesProductLine");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLinesProductLine",
                table: "Products",
                column: "ProductLinesProductLine",
                principalTable: "ProductLines",
                principalColumn: "ProductLine",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
