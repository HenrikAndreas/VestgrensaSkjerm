using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    /// <inheritdoc />
    public partial class MsgSecondaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResidentID",
                table: "Messages",
                newName: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AuthorID",
                table: "Messages",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Residents_AuthorID",
                table: "Messages",
                column: "AuthorID",
                principalTable: "Residents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Residents_AuthorID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AuthorID",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Messages",
                newName: "ResidentID");
        }
    }
}
