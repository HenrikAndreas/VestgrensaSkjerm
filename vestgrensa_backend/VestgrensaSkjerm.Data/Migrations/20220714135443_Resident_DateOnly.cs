using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    /// <inheritdoc />
    public partial class Resident_DateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Residents");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Birthday",
                table: "Residents",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Residents",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Residents",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
