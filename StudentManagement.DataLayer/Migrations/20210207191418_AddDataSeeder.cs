using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.DataLayer.Migrations
{
    public partial class AddDataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "DisciplineId", "DisciplineName", "ProfesorName" },
                values: new object[,]
                {
                    { new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"), "Architecture 101", "Ted Mosby" },
                    { new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"), "Math 102", "Barney Stinson" }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "SemesterId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 1", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e759923c-d499-4548-4f08-08d8cb80e9b4"), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Semester 2", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe" }
                });

            migrationBuilder.InsertData(
                table: "SemesterDisciplines",
                columns: new[] { "Id", "DisciplineId", "SemesterId" },
                values: new object[,]
                {
                    { new Guid("20e30074-7687-4191-4f07-08d8cb80e9b4"), new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"), new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4") },
                    { new Guid("20e30074-7687-4101-4f17-08d8cb80e9b4"), new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"), new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4") }
                });

            migrationBuilder.InsertData(
                table: "StudentDisciplines",
                columns: new[] { "Id", "DisciplineId", "Score", "StudentId" },
                values: new object[,]
                {
                    { new Guid("20e30074-7687-4001-4f07-08d8cb80e9b4"), new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"), 4.0, new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6") },
                    { new Guid("20e30074-7687-4101-4f07-08d8cb70e9b4"), new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"), 2.0, new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6") }
                });

            migrationBuilder.InsertData(
                table: "StudentSemesters",
                columns: new[] { "Id", "SemesterId", "StudentId" },
                values: new object[] { new Guid("20e30074-7687-4101-4f07-08d8cb80e9c4"), new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4"), new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SemesterDisciplines",
                keyColumn: "Id",
                keyValue: new Guid("20e30074-7687-4101-4f17-08d8cb80e9b4"));

            migrationBuilder.DeleteData(
                table: "SemesterDisciplines",
                keyColumn: "Id",
                keyValue: new Guid("20e30074-7687-4191-4f07-08d8cb80e9b4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: new Guid("e759923c-d499-4548-4f08-08d8cb80e9b4"));

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumn: "Id",
                keyValue: new Guid("20e30074-7687-4001-4f07-08d8cb80e9b4"));

            migrationBuilder.DeleteData(
                table: "StudentDisciplines",
                keyColumn: "Id",
                keyValue: new Guid("20e30074-7687-4101-4f07-08d8cb70e9b4"));

            migrationBuilder.DeleteData(
                table: "StudentSemesters",
                keyColumn: "Id",
                keyValue: new Guid("20e30074-7687-4101-4f07-08d8cb80e9c4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "SemesterId",
                keyValue: new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"));
        }
    }
}
