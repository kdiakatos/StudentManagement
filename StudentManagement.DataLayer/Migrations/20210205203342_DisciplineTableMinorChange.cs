using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.DataLayer.Migrations
{
    public partial class DisciplineTableMinorChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Disciplines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Disciplines");
        }
    }
}
