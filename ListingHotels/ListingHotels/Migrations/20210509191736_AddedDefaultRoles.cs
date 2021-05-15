using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingHotels.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97cbbbc0-bd48-4b9b-8249-50a54611796d", "fe9a195b-85ab-4f52-966c-3e856cf63ca6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aad0d2e-27ac-454d-97ab-c41de15cf981", "dcff43c0-d57a-4774-b191-3e69e706b3bf", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aad0d2e-27ac-454d-97ab-c41de15cf981");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97cbbbc0-bd48-4b9b-8249-50a54611796d");
        }
    }
}
