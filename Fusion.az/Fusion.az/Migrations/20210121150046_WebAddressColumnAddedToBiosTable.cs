using Microsoft.EntityFrameworkCore.Migrations;

namespace Fusion.az.Migrations
{
    public partial class WebAddressColumnAddedToBiosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebAddress",
                table: "Bios",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebAddress",
                table: "Bios");
        }
    }
}
