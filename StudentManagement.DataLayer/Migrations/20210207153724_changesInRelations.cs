using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.DataLayer.Migrations
{
    public partial class changesInRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Disciplines");

            migrationBuilder.CreateTable(
                name: "StudentDiscipline",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisciplineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDiscipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDiscipline_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDiscipline_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiscipline_DisciplineId",
                table: "StudentDiscipline",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiscipline_StudentId",
                table: "StudentDiscipline",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDiscipline");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Disciplines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
