using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    /// <inheritdoc />
    public partial class MsgChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Residents_AuthorID",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Residents",
                newName: "ResidentID");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Messages",
                newName: "ResidentID");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_AuthorID",
                table: "Messages",
                newName: "IX_Messages_ResidentID");

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

            migrationBuilder.RenameColumn(
                name: "ResidentID",
                table: "Residents",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ResidentID",
                table: "Messages",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ResidentID",
                table: "Messages",
                newName: "IX_Messages_AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Residents_AuthorID",
                table: "Messages",
                column: "AuthorID",
                principalTable: "Residents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
