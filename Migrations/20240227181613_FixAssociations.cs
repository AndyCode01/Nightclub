using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class FixAssociations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Type_documents_Clients_clientId_client",
                table: "Type_documents");

            migrationBuilder.DropIndex(
                name: "IX_Type_documents_clientId_client",
                table: "Type_documents");

            migrationBuilder.DropColumn(
                name: "clientId_client",
                table: "Type_documents");

            migrationBuilder.AddColumn<int>(
                name: "type_documentsId_type_document",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_type_documentsId_type_document",
                table: "Clients",
                column: "type_documentsId_type_document");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Type_documents_type_documentsId_type_document",
                table: "Clients",
                column: "type_documentsId_type_document",
                principalTable: "Type_documents",
                principalColumn: "Id_type_document",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Type_documents_type_documentsId_type_document",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_type_documentsId_type_document",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "type_documentsId_type_document",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "clientId_client",
                table: "Type_documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Type_documents_clientId_client",
                table: "Type_documents",
                column: "clientId_client");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_documents_Clients_clientId_client",
                table: "Type_documents",
                column: "clientId_client",
                principalTable: "Clients",
                principalColumn: "Id_client",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
