using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Migrations
{
    public partial class newMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThisUsername",
                table: "UserEventDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "UserEventDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetails_User",
                table: "UserEventDetails",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEventDetails_User_User",
                table: "UserEventDetails",
                column: "User",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetails_User_User",
                table: "UserEventDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserEventDetails_User",
                table: "UserEventDetails");

            migrationBuilder.DropColumn(
                name: "ThisUsername",
                table: "UserEventDetails");

            migrationBuilder.DropColumn(
                name: "User",
                table: "UserEventDetails");
        }
    }
}
