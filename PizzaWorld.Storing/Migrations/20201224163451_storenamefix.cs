using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class storenamefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 3L, "LaMarrino's" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 1L, "LaMarrino's" });
        }
    }
}
