using Microsoft.EntityFrameworkCore.Migrations;

namespace shop.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "AdId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 1, "1 room apartmant for cheap price", 10000, 11, "1 room apartmant" },
                    { 2, "2 room apartmant for cheap price", 20000, 11, "2 room apartmant" },
                    { 3, "3 room apartmant for cheap price", 30000, 11, "3 room apartmant" },
                    { 4, "small house  for cheap price", 50000, 12, "small house" },
                    { 5, "Big luxury house  for great price", 100000, 12, "big house" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5);
        }
    }
}
