using Microsoft.EntityFrameworkCore.Migrations;

namespace shop.Migrations
{
    public partial class model_changed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                column: "CategoryId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                column: "CategoryId",
                value: 0);
        }
    }
}
