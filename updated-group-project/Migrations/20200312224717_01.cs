using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserEventDetails");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "UserEventDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserEventDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "UserEventDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
