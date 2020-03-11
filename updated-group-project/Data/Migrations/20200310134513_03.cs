using Microsoft.EntityFrameworkCore.Migrations;

namespace updated_group_project.Data.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EventLocation",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventPrice",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Events");

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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllDay",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Free",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Events",
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

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "catagoryId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Events",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "ProfileId");

            migrationBuilder.CreateTable(
                name: "Catagory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileId",
                table: "User",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_catagoryId",
                table: "Events",
                column: "catagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Catagory_catagoryId",
                table: "Events",
                column: "catagoryId",
                principalTable: "Catagory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Events_Catagory_catagoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Profile_ProfileId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Catagory");

            migrationBuilder.DropIndex(
                name: "IX_User_ProfileId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Events_catagoryId",
                table: "Events");

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
                name: "Address",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AllDay",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Free",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "catagoryId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "description",
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

            migrationBuilder.AddColumn<string>(
                name: "EventLocation",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventPrice",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "name");
        }
    }
}
