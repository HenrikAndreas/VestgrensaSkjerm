using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    /// <inheritdoc />
    public partial class MsgIsFakked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Residents_ResidentID",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "ResidentID",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Residents_ResidentID",
                table: "Messages",
                column: "ResidentID",
                principalTable: "Residents",
                principalColumn: "ResidentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Residents_ResidentID",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "ResidentID",
                table: "Messages",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Residents_ResidentID",
                table: "Messages",
                column: "ResidentID",
                principalTable: "Residents",
                principalColumn: "ResidentID");
        }
    }
}
