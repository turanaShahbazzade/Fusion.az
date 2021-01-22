using Microsoft.EntityFrameworkCore.Migrations;

namespace Fusion.az.Migrations
{
    public partial class CloseColumnRemovedFromBiosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Close",
                table: "Bios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Close",
                table: "Bios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
