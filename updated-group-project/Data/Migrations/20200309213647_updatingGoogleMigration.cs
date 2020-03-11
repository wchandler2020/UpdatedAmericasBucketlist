using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Data.Migrations
{
    public partial class updatingGoogleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Date = table.Column<DateTime>(nullable: false),
                    TodaysWeather = table.Column<string>(nullable: true),
                    Tempurature = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Date);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
