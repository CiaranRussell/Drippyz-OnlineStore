using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrippyzOnlineStore.Data.Migrations
{
    public partial class updateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandNames_Brand-ID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTag_SpecialTag-ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Brand-ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpecialTag-ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Brand-ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SpecialTag-ID",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandNameID",
                table: "Products",
                column: "BrandNameID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecialTagID",
                table: "Products",
                column: "SpecialTagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandNames_BrandNameID",
                table: "Products",
                column: "BrandNameID",
                principalTable: "BrandNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagID",
                table: "Products",
                column: "SpecialTagID",
                principalTable: "SpecialTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandNames_BrandNameID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandNameID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpecialTagID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Brand-ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialTag-ID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Brand-ID",
                table: "Products",
                column: "Brand-ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecialTag-ID",
                table: "Products",
                column: "SpecialTag-ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandNames_Brand-ID",
                table: "Products",
                column: "Brand-ID",
                principalTable: "BrandNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTag_SpecialTag-ID",
                table: "Products",
                column: "SpecialTag-ID",
                principalTable: "SpecialTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
