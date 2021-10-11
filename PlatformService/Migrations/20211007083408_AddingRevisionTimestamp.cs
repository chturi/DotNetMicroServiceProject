using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformService.Migrations
{
    public partial class AddingRevisionTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Revision",
                table: "Platforms",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Revision",
                table: "Platforms");
        }
    }
}
