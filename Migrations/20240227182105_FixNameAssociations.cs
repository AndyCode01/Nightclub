using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nigthclub.Migrations
{
    /// <inheritdoc />
    public partial class FixNameAssociations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_type_document",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_type_document",
                table: "Clients");
        }
    }
}
