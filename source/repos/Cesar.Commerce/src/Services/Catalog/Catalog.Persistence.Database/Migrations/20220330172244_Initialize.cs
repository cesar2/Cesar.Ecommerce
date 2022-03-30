using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 299m },
                    { 72, "Description for product 72", "Product 72", 138m },
                    { 71, "Description for product 71", "Product 71", 981m },
                    { 70, "Description for product 70", "Product 70", 405m },
                    { 69, "Description for product 69", "Product 69", 565m },
                    { 68, "Description for product 68", "Product 68", 360m },
                    { 67, "Description for product 67", "Product 67", 861m },
                    { 66, "Description for product 66", "Product 66", 814m },
                    { 65, "Description for product 65", "Product 65", 532m },
                    { 64, "Description for product 64", "Product 64", 264m },
                    { 63, "Description for product 63", "Product 63", 570m },
                    { 62, "Description for product 62", "Product 62", 689m },
                    { 61, "Description for product 61", "Product 61", 335m },
                    { 60, "Description for product 60", "Product 60", 732m },
                    { 59, "Description for product 59", "Product 59", 456m },
                    { 58, "Description for product 58", "Product 58", 953m },
                    { 57, "Description for product 57", "Product 57", 104m },
                    { 56, "Description for product 56", "Product 56", 849m },
                    { 55, "Description for product 55", "Product 55", 110m },
                    { 54, "Description for product 54", "Product 54", 971m },
                    { 53, "Description for product 53", "Product 53", 544m },
                    { 52, "Description for product 52", "Product 52", 245m },
                    { 73, "Description for product 73", "Product 73", 902m },
                    { 51, "Description for product 51", "Product 51", 217m },
                    { 74, "Description for product 74", "Product 74", 146m },
                    { 76, "Description for product 76", "Product 76", 590m },
                    { 97, "Description for product 97", "Product 97", 410m },
                    { 96, "Description for product 96", "Product 96", 550m },
                    { 95, "Description for product 95", "Product 95", 403m },
                    { 94, "Description for product 94", "Product 94", 627m },
                    { 93, "Description for product 93", "Product 93", 943m },
                    { 92, "Description for product 92", "Product 92", 658m },
                    { 91, "Description for product 91", "Product 91", 151m },
                    { 90, "Description for product 90", "Product 90", 557m },
                    { 89, "Description for product 89", "Product 89", 614m },
                    { 88, "Description for product 88", "Product 88", 857m },
                    { 87, "Description for product 87", "Product 87", 884m },
                    { 86, "Description for product 86", "Product 86", 299m },
                    { 85, "Description for product 85", "Product 85", 533m },
                    { 84, "Description for product 84", "Product 84", 302m },
                    { 83, "Description for product 83", "Product 83", 239m },
                    { 82, "Description for product 82", "Product 82", 962m },
                    { 81, "Description for product 81", "Product 81", 711m },
                    { 80, "Description for product 80", "Product 80", 537m },
                    { 79, "Description for product 79", "Product 79", 744m },
                    { 78, "Description for product 78", "Product 78", 571m },
                    { 77, "Description for product 77", "Product 77", 181m },
                    { 75, "Description for product 75", "Product 75", 210m },
                    { 98, "Description for product 98", "Product 98", 203m },
                    { 50, "Description for product 50", "Product 50", 161m },
                    { 48, "Description for product 48", "Product 48", 939m },
                    { 22, "Description for product 22", "Product 22", 449m },
                    { 21, "Description for product 21", "Product 21", 471m },
                    { 20, "Description for product 20", "Product 20", 350m },
                    { 19, "Description for product 19", "Product 19", 685m },
                    { 18, "Description for product 18", "Product 18", 262m },
                    { 17, "Description for product 17", "Product 17", 439m },
                    { 16, "Description for product 16", "Product 16", 593m },
                    { 15, "Description for product 15", "Product 15", 461m },
                    { 14, "Description for product 14", "Product 14", 873m },
                    { 13, "Description for product 13", "Product 13", 884m },
                    { 12, "Description for product 12", "Product 12", 690m },
                    { 11, "Description for product 11", "Product 11", 242m },
                    { 10, "Description for product 10", "Product 10", 877m },
                    { 9, "Description for product 9", "Product 9", 815m },
                    { 8, "Description for product 8", "Product 8", 835m },
                    { 7, "Description for product 7", "Product 7", 204m },
                    { 6, "Description for product 6", "Product 6", 237m },
                    { 5, "Description for product 5", "Product 5", 749m },
                    { 4, "Description for product 4", "Product 4", 231m },
                    { 3, "Description for product 3", "Product 3", 519m },
                    { 2, "Description for product 2", "Product 2", 448m },
                    { 23, "Description for product 23", "Product 23", 443m },
                    { 49, "Description for product 49", "Product 49", 375m },
                    { 24, "Description for product 24", "Product 24", 565m },
                    { 26, "Description for product 26", "Product 26", 116m },
                    { 47, "Description for product 47", "Product 47", 405m },
                    { 46, "Description for product 46", "Product 46", 336m },
                    { 45, "Description for product 45", "Product 45", 821m },
                    { 44, "Description for product 44", "Product 44", 872m },
                    { 43, "Description for product 43", "Product 43", 368m },
                    { 42, "Description for product 42", "Product 42", 881m },
                    { 41, "Description for product 41", "Product 41", 240m },
                    { 40, "Description for product 40", "Product 40", 639m },
                    { 39, "Description for product 39", "Product 39", 360m },
                    { 38, "Description for product 38", "Product 38", 400m },
                    { 37, "Description for product 37", "Product 37", 611m },
                    { 36, "Description for product 36", "Product 36", 155m },
                    { 35, "Description for product 35", "Product 35", 407m },
                    { 34, "Description for product 34", "Product 34", 624m },
                    { 33, "Description for product 33", "Product 33", 829m },
                    { 32, "Description for product 32", "Product 32", 428m },
                    { 31, "Description for product 31", "Product 31", 445m },
                    { 30, "Description for product 30", "Product 30", 650m },
                    { 29, "Description for product 29", "Product 29", 364m },
                    { 28, "Description for product 28", "Product 28", 515m },
                    { 27, "Description for product 27", "Product 27", 902m },
                    { 25, "Description for product 25", "Product 25", 774m },
                    { 99, "Description for product 99", "Product 99", 439m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 17 },
                    { 72, 72, 3 },
                    { 71, 71, 5 },
                    { 70, 70, 6 },
                    { 69, 69, 11 },
                    { 68, 68, 4 },
                    { 67, 67, 6 },
                    { 66, 66, 8 },
                    { 65, 65, 8 },
                    { 64, 64, 5 },
                    { 63, 63, 6 },
                    { 62, 62, 9 },
                    { 61, 61, 13 },
                    { 60, 60, 14 },
                    { 59, 59, 19 },
                    { 58, 58, 5 },
                    { 57, 57, 15 },
                    { 56, 56, 18 },
                    { 55, 55, 8 },
                    { 54, 54, 4 },
                    { 53, 53, 7 },
                    { 52, 52, 12 },
                    { 73, 73, 16 },
                    { 51, 51, 12 },
                    { 74, 74, 15 },
                    { 76, 76, 12 },
                    { 97, 97, 8 },
                    { 96, 96, 16 },
                    { 95, 95, 10 },
                    { 94, 94, 7 },
                    { 93, 93, 19 },
                    { 92, 92, 2 },
                    { 91, 91, 19 },
                    { 90, 90, 7 },
                    { 89, 89, 18 },
                    { 88, 88, 8 },
                    { 87, 87, 12 },
                    { 86, 86, 14 },
                    { 85, 85, 19 },
                    { 84, 84, 12 },
                    { 83, 83, 1 },
                    { 82, 82, 1 },
                    { 81, 81, 12 },
                    { 80, 80, 16 },
                    { 79, 79, 17 },
                    { 78, 78, 3 },
                    { 77, 77, 18 },
                    { 75, 75, 16 },
                    { 98, 98, 15 },
                    { 50, 50, 10 },
                    { 48, 48, 16 },
                    { 22, 22, 19 },
                    { 21, 21, 6 },
                    { 20, 20, 2 },
                    { 19, 19, 19 },
                    { 18, 18, 18 },
                    { 17, 17, 2 },
                    { 16, 16, 13 },
                    { 15, 15, 1 },
                    { 14, 14, 17 },
                    { 13, 13, 11 },
                    { 12, 12, 0 },
                    { 11, 11, 8 },
                    { 10, 10, 14 },
                    { 9, 9, 17 },
                    { 8, 8, 9 },
                    { 7, 7, 16 },
                    { 6, 6, 11 },
                    { 5, 5, 13 },
                    { 4, 4, 12 },
                    { 3, 3, 15 },
                    { 2, 2, 19 },
                    { 23, 23, 4 },
                    { 49, 49, 5 },
                    { 24, 24, 9 },
                    { 26, 26, 18 },
                    { 47, 47, 6 },
                    { 46, 46, 16 },
                    { 45, 45, 12 },
                    { 44, 44, 1 },
                    { 43, 43, 1 },
                    { 42, 42, 14 },
                    { 41, 41, 6 },
                    { 40, 40, 4 },
                    { 39, 39, 2 },
                    { 38, 38, 19 },
                    { 37, 37, 7 },
                    { 36, 36, 14 },
                    { 35, 35, 5 },
                    { 34, 34, 6 },
                    { 33, 33, 13 },
                    { 32, 32, 19 },
                    { 31, 31, 6 },
                    { 30, 30, 11 },
                    { 29, 29, 3 },
                    { 28, 28, 6 },
                    { 27, 27, 17 },
                    { 25, 25, 12 },
                    { 99, 99, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
