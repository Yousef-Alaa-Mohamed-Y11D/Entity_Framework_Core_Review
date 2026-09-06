using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Core_Review.Migrations
{
    /// <inheritdoc />
    public partial class Bug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AuditEntry",
                newName: "AuditEntry",
                newSchema: "Blogging");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AuditEntry",
                schema: "Blogging",
                newName: "AuditEntry");
        }
    }
}
