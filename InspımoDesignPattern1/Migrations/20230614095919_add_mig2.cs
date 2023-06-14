using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InspımoDesignPattern1.Migrations
{
    public partial class add_mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostomerName",
                table: "customerProcesses",
                newName: "CustomerName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProcessDate",
                table: "customerProcesses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "customerProcesses",
                newName: "CostomerName");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessDate",
                table: "customerProcesses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
