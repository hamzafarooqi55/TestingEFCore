using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingEFCore.Migrations
{
    public partial class AddedPhoneNumberColumnInStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Student",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Student");
        }
    }
}
