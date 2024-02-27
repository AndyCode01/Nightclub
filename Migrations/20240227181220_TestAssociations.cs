using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class TestAssociations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assistant_roles",
                columns: table => new
                {
                    Id_assistant_role = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_assistant_role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistant_roles", x => x.Id_assistant_role);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id_client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname_client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document_number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id_client);
                });

            migrationBuilder.CreateTable(
                name: "Type_documents",
                columns: table => new
                {
                    Id_type_document = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_type_document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId_client = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_documents", x => x.Id_type_document);
                    table.ForeignKey(
                        name: "FK_Type_documents_Clients_clientId_client",
                        column: x => x.clientId_client,
                        principalTable: "Clients",
                        principalColumn: "Id_client",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Type_documents_clientId_client",
                table: "Type_documents",
                column: "clientId_client");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assistant_roles");

            migrationBuilder.DropTable(
                name: "Type_documents");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
