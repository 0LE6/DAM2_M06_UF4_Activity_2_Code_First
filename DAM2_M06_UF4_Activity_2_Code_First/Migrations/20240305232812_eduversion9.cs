using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class eduversion9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines");

            migrationBuilder.RenameTable(
                name: "ProductLines",
                newName: "ProductLine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLine",
                table: "ProductLine",
                column: "ProductLines");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLine_ProductLines",
                table: "Products",
                column: "ProductLines",
                principalTable: "ProductLine",
                principalColumn: "ProductLines",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLine_ProductLines",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLine",
                table: "ProductLine");

            migrationBuilder.RenameTable(
                name: "ProductLine",
                newName: "ProductLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLines",
                table: "ProductLines",
                column: "ProductLines");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLines_ProductLines",
                table: "Products",
                column: "ProductLines",
                principalTable: "ProductLines",
                principalColumn: "ProductLines",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
