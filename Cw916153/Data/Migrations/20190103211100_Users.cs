using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw916153.Data.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Module",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Module_ApplicationUserId",
                table: "Module",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_AspNetUsers_ApplicationUserId",
                table: "Module",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_AspNetUsers_ApplicationUserId",
                table: "Module");

            migrationBuilder.DropIndex(
                name: "IX_Module_ApplicationUserId",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
