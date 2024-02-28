using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class FixCompleteDatabaseDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Clients_client_Id_client",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Event_event_Id_event",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_event_Id_event",
                table: "Tickets",
                newName: "IX_Tickets_event_Id_event");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_client_Id_client",
                table: "Tickets",
                newName: "IX_Tickets_client_Id_client");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id_ticket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id_event");

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id_artist = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname_artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary_artist = table.Column<int>(type: "int", nullable: false),
                    document_Id_type_document = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id_artist);
                    table.ForeignKey(
                        name: "FK_Artists_Type_documents_document_Id_type_document",
                        column: x => x.document_Id_type_document,
                        principalTable: "Type_documents",
                        principalColumn: "Id_type_document",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assistants",
                columns: table => new
                {
                    Id_assistant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_assistant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname_assistant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document_Id_type_document = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistants", x => x.Id_assistant);
                    table.ForeignKey(
                        name: "FK_Assistants_Type_documents_document_Id_type_document",
                        column: x => x.document_Id_type_document,
                        principalTable: "Type_documents",
                        principalColumn: "Id_type_document",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Type_Rols",
                columns: table => new
                {
                    Id_type_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Rols", x => x.Id_type_rol);
                });

            migrationBuilder.CreateTable(
                name: "Event_Artists",
                columns: table => new
                {
                    Id_event_artist = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assistant_Id_assistant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Artists", x => x.Id_event_artist);
                    table.ForeignKey(
                        name: "FK_Event_Artists_Assistants_assistant_Id_assistant",
                        column: x => x.assistant_Id_assistant,
                        principalTable: "Assistants",
                        principalColumn: "Id_assistant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event_Assistants",
                columns: table => new
                {
                    Id_event_assistant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assistant_Id_assistant = table.Column<int>(type: "int", nullable: false),
                    rol_Id_type_rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Assistants", x => x.Id_event_assistant);
                    table.ForeignKey(
                        name: "FK_Event_Assistants_Assistants_assistant_Id_assistant",
                        column: x => x.assistant_Id_assistant,
                        principalTable: "Assistants",
                        principalColumn: "Id_assistant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Assistants_Type_Rols_rol_Id_type_rol",
                        column: x => x.rol_Id_type_rol,
                        principalTable: "Type_Rols",
                        principalColumn: "Id_type_rol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_document_Id_type_document",
                table: "Artists",
                column: "document_Id_type_document");

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_document_Id_type_document",
                table: "Assistants",
                column: "document_Id_type_document");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Artists_assistant_Id_assistant",
                table: "Event_Artists",
                column: "assistant_Id_assistant");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Assistants_assistant_Id_assistant",
                table: "Event_Assistants",
                column: "assistant_Id_assistant");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Assistants_rol_Id_type_rol",
                table: "Event_Assistants",
                column: "rol_Id_type_rol");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_client_Id_client",
                table: "Tickets",
                column: "client_Id_client",
                principalTable: "Clients",
                principalColumn: "Id_client",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_event_Id_event",
                table: "Tickets",
                column: "event_Id_event",
                principalTable: "Events",
                principalColumn: "Id_event",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_client_Id_client",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_event_Id_event",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Event_Artists");

            migrationBuilder.DropTable(
                name: "Event_Assistants");

            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "Type_Rols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_event_Id_event",
                table: "Ticket",
                newName: "IX_Ticket_event_Id_event");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_client_Id_client",
                table: "Ticket",
                newName: "IX_Ticket_client_Id_client");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id_ticket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id_event");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Clients_client_Id_client",
                table: "Ticket",
                column: "client_Id_client",
                principalTable: "Clients",
                principalColumn: "Id_client",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Event_event_Id_event",
                table: "Ticket",
                column: "event_Id_event",
                principalTable: "Event",
                principalColumn: "Id_event",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
