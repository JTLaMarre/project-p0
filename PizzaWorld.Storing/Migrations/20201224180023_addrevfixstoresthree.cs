using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addrevfixstoresthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "Revenue" },
                values: new object[] { 5L, "LaMarrinos", 0 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "Revenue" },
                values: new object[] { 6L, "Meetzeronis", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 6L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "Revenue" },
                values: new object[] { 1L, "LaMarrinos", 0 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "Revenue" },
                values: new object[] { 2L, "Meetzeronis", 0 });
        }
    }
}
