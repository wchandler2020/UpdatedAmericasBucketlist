using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "UserEventDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "review",
                table: "UserEventDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "UserEventDetails");

            migrationBuilder.DropColumn(
                name: "review",
                table: "UserEventDetails");
        }
    }
}
