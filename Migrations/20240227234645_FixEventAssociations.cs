using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class FixEventAssociations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "event_Id_event",
                table: "Event_Assistants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "event_Id_event",
                table: "Event_Artists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Event_Assistants_event_Id_event",
                table: "Event_Assistants",
                column: "event_Id_event");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Artists_event_Id_event",
                table: "Event_Artists",
                column: "event_Id_event");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Artists_Events_event_Id_event",
                table: "Event_Artists",
                column: "event_Id_event",
                principalTable: "Events",
                principalColumn: "Id_event",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Assistants_Events_event_Id_event",
                table: "Event_Assistants",
                column: "event_Id_event",
                principalTable: "Events",
                principalColumn: "Id_event",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Artists_Events_event_Id_event",
                table: "Event_Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Assistants_Events_event_Id_event",
                table: "Event_Assistants");

            migrationBuilder.DropIndex(
                name: "IX_Event_Assistants_event_Id_event",
                table: "Event_Assistants");

            migrationBuilder.DropIndex(
                name: "IX_Event_Artists_event_Id_event",
                table: "Event_Artists");

            migrationBuilder.DropColumn(
                name: "event_Id_event",
                table: "Event_Assistants");

            migrationBuilder.DropColumn(
                name: "event_Id_event",
                table: "Event_Artists");
        }
    }
}
