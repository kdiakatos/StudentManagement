using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.DataLayer.Migrations
{
    public partial class addedMissingDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SemesterDiscipline_Disciplines_DisciplineId",
                table: "SemesterDiscipline");

            migrationBuilder.DropForeignKey(
                name: "FK_SemesterDiscipline_Semesters_SemesterId",
                table: "SemesterDiscipline");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentDiscipline_Disciplines_DisciplineId",
                table: "StudentDiscipline");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentDiscipline_Students_StudentId",
                table: "StudentDiscipline");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemester_Semesters_SemesterId",
                table: "StudentSemester");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemester_Students_StudentId",
                table: "StudentSemester");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSemester",
                table: "StudentSemester");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDiscipline",
                table: "StudentDiscipline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SemesterDiscipline",
                table: "SemesterDiscipline");

            migrationBuilder.RenameTable(
                name: "StudentSemester",
                newName: "StudentSemesters");

            migrationBuilder.RenameTable(
                name: "StudentDiscipline",
                newName: "StudentDisciplines");

            migrationBuilder.RenameTable(
                name: "SemesterDiscipline",
                newName: "SemesterDisciplines");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemester_StudentId",
                table: "StudentSemesters",
                newName: "IX_StudentSemesters_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemester_SemesterId",
                table: "StudentSemesters",
                newName: "IX_StudentSemesters_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentDiscipline_StudentId",
                table: "StudentDisciplines",
                newName: "IX_StudentDisciplines_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentDiscipline_DisciplineId",
                table: "StudentDisciplines",
                newName: "IX_StudentDisciplines_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_SemesterDiscipline_SemesterId",
                table: "SemesterDisciplines",
                newName: "IX_SemesterDisciplines_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_SemesterDiscipline_DisciplineId",
                table: "SemesterDisciplines",
                newName: "IX_SemesterDisciplines_DisciplineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSemesters",
                table: "StudentSemesters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDisciplines",
                table: "StudentDisciplines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SemesterDisciplines",
                table: "SemesterDisciplines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SemesterDisciplines_Disciplines_DisciplineId",
                table: "SemesterDisciplines",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemesterDisciplines_Semesters_SemesterId",
                table: "SemesterDisciplines",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentDisciplines_Disciplines_DisciplineId",
                table: "StudentDisciplines",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentDisciplines_Students_StudentId",
                table: "StudentDisciplines",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemesters_Semesters_SemesterId",
                table: "StudentSemesters",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemesters_Students_StudentId",
                table: "StudentSemesters",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SemesterDisciplines_Disciplines_DisciplineId",
                table: "SemesterDisciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_SemesterDisciplines_Semesters_SemesterId",
                table: "SemesterDisciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentDisciplines_Disciplines_DisciplineId",
                table: "StudentDisciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentDisciplines_Students_StudentId",
                table: "StudentDisciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemesters_Semesters_SemesterId",
                table: "StudentSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemesters_Students_StudentId",
                table: "StudentSemesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSemesters",
                table: "StudentSemesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDisciplines",
                table: "StudentDisciplines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SemesterDisciplines",
                table: "SemesterDisciplines");

            migrationBuilder.RenameTable(
                name: "StudentSemesters",
                newName: "StudentSemester");

            migrationBuilder.RenameTable(
                name: "StudentDisciplines",
                newName: "StudentDiscipline");

            migrationBuilder.RenameTable(
                name: "SemesterDisciplines",
                newName: "SemesterDiscipline");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemesters_StudentId",
                table: "StudentSemester",
                newName: "IX_StudentSemester_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemesters_SemesterId",
                table: "StudentSemester",
                newName: "IX_StudentSemester_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentDisciplines_StudentId",
                table: "StudentDiscipline",
                newName: "IX_StudentDiscipline_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentDisciplines_DisciplineId",
                table: "StudentDiscipline",
                newName: "IX_StudentDiscipline_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_SemesterDisciplines_SemesterId",
                table: "SemesterDiscipline",
                newName: "IX_SemesterDiscipline_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_SemesterDisciplines_DisciplineId",
                table: "SemesterDiscipline",
                newName: "IX_SemesterDiscipline_DisciplineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSemester",
                table: "StudentSemester",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDiscipline",
                table: "StudentDiscipline",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SemesterDiscipline",
                table: "SemesterDiscipline",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SemesterDiscipline_Disciplines_DisciplineId",
                table: "SemesterDiscipline",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SemesterDiscipline_Semesters_SemesterId",
                table: "SemesterDiscipline",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentDiscipline_Disciplines_DisciplineId",
                table: "StudentDiscipline",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentDiscipline_Students_StudentId",
                table: "StudentDiscipline",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemester_Semesters_SemesterId",
                table: "StudentSemester",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemester_Students_StudentId",
                table: "StudentSemester",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
