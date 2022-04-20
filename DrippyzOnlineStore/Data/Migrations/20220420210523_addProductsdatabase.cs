using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrippyzOnlineStore.Data.Migrations
{
    public partial class addProductsdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    BrandNameID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(name: "Brand-ID", type: "int", nullable: false),
                    SpecialTagID = table.Column<int>(type: "int", nullable: false),
                    SpecialTagID0 = table.Column<int>(name: "SpecialTag-ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductCode);
                    table.ForeignKey(
                        name: "FK_Products_BrandNames_Brand-ID",
                        column: x => x.BrandID,
                        principalTable: "BrandNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SpecialTag_SpecialTag-ID",
                        column: x => x.SpecialTagID0,
                        principalTable: "SpecialTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Brand-ID",
                table: "Products",
                column: "Brand-ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecialTag-ID",
                table: "Products",
                column: "SpecialTag-ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
