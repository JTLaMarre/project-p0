using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class storename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crust",
                table: "Pizzas");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 1L, "LaMarrino's" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 2L, "Meetzeroni's" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Crust",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
