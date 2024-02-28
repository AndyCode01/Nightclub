using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class CompleteDatabaseDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id_event = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id_event);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id_ticket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_join = table.Column<DateOnly>(type: "date", nullable: false),
                    event_Id_event = table.Column<int>(type: "int", nullable: false),
                    client_Id_client = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id_ticket);
                    table.ForeignKey(
                        name: "FK_Ticket_Clients_client_Id_client",
                        column: x => x.client_Id_client,
                        principalTable: "Clients",
                        principalColumn: "Id_client",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Event_event_Id_event",
                        column: x => x.event_Id_event,
                        principalTable: "Event",
                        principalColumn: "Id_event",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_client_Id_client",
                table: "Ticket",
                column: "client_Id_client");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_event_Id_event",
                table: "Ticket",
                column: "event_Id_event");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
