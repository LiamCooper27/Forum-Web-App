using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw916153.Data.Migrations
{
    public partial class CommentUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAnon",
                table: "Comment",
                newName: "IsAnon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAnon",
                table: "Comment",
                newName: "isAnon");
        }
    }
}
