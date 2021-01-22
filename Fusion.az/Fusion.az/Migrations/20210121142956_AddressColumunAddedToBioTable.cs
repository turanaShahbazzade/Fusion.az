using Microsoft.EntityFrameworkCore.Migrations;

namespace Fusion.az.Migrations
{
    public partial class AddressColumunAddedToBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Bios",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Bios");
        }
    }
}
