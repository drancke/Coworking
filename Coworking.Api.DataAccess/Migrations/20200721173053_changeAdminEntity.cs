using Microsoft.EntityFrameworkCore.Migrations;

namespace Coworking.Api.DataAccess.Migrations
{
    public partial class changeAdminEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Office_Admin_IdAdmin",
                table: "Office");

            migrationBuilder.DropIndex(
                name: "IX_Office_IdAdmin",
                table: "Office");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Office",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Office_AdminId",
                table: "Office",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Admin_AdminId",
                table: "Office",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Office_Admin_AdminId",
                table: "Office");

            migrationBuilder.DropIndex(
                name: "IX_Office_AdminId",
                table: "Office");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Office");

            migrationBuilder.CreateIndex(
                name: "IX_Office_IdAdmin",
                table: "Office",
                column: "IdAdmin",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Admin_IdAdmin",
                table: "Office",
                column: "IdAdmin",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
