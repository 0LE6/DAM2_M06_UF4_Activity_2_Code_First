using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_Activity_2_Code_First.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductLine1",
                table: "Products",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ProductLine = table.Column<string>(nullable: false),
                    TextDescription = table.Column<string>(nullable: false),
                    HtmlDescription = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ProductLine);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLines_ProductLine1",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductLines");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLine1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLine1",
                table: "Products");
        }
    }
}
