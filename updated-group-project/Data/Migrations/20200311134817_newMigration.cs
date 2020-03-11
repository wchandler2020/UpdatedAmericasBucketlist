using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Data.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Profile",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "User",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Profile",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Profile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Profile",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Events",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileId",
                table: "User",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ProfileId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Profile",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Profile",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "name");

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tempurature = table.Column<int>(type: "int", nullable: false),
                    TodaysWeather = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Date);
                });
        }
    }
}
