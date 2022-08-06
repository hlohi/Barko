using Microsoft.EntityFrameworkCore.Migrations;

namespace Barko.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Logins");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Logins",
                newName: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Logins",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdNumber",
                table: "Logins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
