using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addrevfixstores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.AddColumn<int>(
                name: "Revenue",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name", "Revenue" },
                values: new object[] { 1L, "LaMarrino's", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "Stores");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 3L, "LaMarrino's" });
        }
    }
}
