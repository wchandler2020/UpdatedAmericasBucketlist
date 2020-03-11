using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Data.Migrations
{
    public partial class thing1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AppUserId",
                table: "User",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_AppUserId",
                table: "User",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_AppUserId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_AppUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
