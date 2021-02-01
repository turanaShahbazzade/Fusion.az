using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fusion.az.Migrations
{
    public partial class IsDeletedAndDeleteTimeDescriptionColumnsRemovedFromHeaderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Headers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Headers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Headers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Headers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
