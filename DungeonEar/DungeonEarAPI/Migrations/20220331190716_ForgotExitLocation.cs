using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonEarAPI.Migrations
{
    public partial class ForgotExitLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExitDirection",
                table: "Exits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExitDirection",
                table: "Exits");
        }
    }
}
