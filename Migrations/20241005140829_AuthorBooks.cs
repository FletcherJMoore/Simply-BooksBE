using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simply_Books_BE.Migrations
{
    public partial class AuthorBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "Books",
                newName: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "Author_Id");
        }
    }
}
