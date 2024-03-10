using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class Version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Artists_Assistants_assistant_Id_assistant",
                table: "Event_Artists");

            migrationBuilder.RenameColumn(
                name: "assistant_Id_assistant",
                table: "Event_Artists",
                newName: "artist_Id_artist");

            migrationBuilder.RenameIndex(
                name: "IX_Event_Artists_assistant_Id_assistant",
                table: "Event_Artists",
                newName: "IX_Event_Artists_artist_Id_artist");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Artists_Artists_artist_Id_artist",
                table: "Event_Artists",
                column: "artist_Id_artist",
                principalTable: "Artists",
                principalColumn: "Id_artist",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Artists_Artists_artist_Id_artist",
                table: "Event_Artists");

            migrationBuilder.RenameColumn(
                name: "artist_Id_artist",
                table: "Event_Artists",
                newName: "assistant_Id_assistant");

            migrationBuilder.RenameIndex(
                name: "IX_Event_Artists_artist_Id_artist",
                table: "Event_Artists",
                newName: "IX_Event_Artists_assistant_Id_assistant");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Artists_Assistants_assistant_Id_assistant",
                table: "Event_Artists",
                column: "assistant_Id_assistant",
                principalTable: "Assistants",
                principalColumn: "Id_assistant",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
