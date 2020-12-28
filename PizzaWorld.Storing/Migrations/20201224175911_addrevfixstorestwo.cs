using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addrevfixstorestwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "LaMarrinos");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Meetzeronis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "LaMarrino's");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Meetzeroni's");
        }
    }
}
