using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    /// <inheritdoc />
    public partial class CurrentResidentsBoolean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Current",
                table: "Residents",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Current",
                table: "Residents");
        }
    }
}
