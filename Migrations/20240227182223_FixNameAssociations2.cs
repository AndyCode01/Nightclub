using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class FixNameAssociations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Type_documents_type_documentsId_type_document",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Id_type_document",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "type_documentsId_type_document",
                table: "Clients",
                newName: "document_Id_type_document");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_type_documentsId_type_document",
                table: "Clients",
                newName: "IX_Clients_document_Id_type_document");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Type_documents_document_Id_type_document",
                table: "Clients",
                column: "document_Id_type_document",
                principalTable: "Type_documents",
                principalColumn: "Id_type_document",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Type_documents_document_Id_type_document",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "document_Id_type_document",
                table: "Clients",
                newName: "type_documentsId_type_document");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_document_Id_type_document",
                table: "Clients",
                newName: "IX_Clients_type_documentsId_type_document");

            migrationBuilder.AddColumn<int>(
                name: "Id_type_document",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Type_documents_type_documentsId_type_document",
                table: "Clients",
                column: "type_documentsId_type_document",
                principalTable: "Type_documents",
                principalColumn: "Id_type_document",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
