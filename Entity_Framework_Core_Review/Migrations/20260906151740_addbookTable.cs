using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Core_Review.Migrations
{
    /// <inheritdoc />
    public partial class addbookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AuditEntry",
                newName: "AuditEntry",
                newSchema: "Blogging");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "Blogging",
                columns: table => new
                {
                    BookNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "Blogging");

            migrationBuilder.RenameTable(
                name: "AuditEntry",
                schema: "Blogging",
                newName: "AuditEntry");
        }
    }
}
