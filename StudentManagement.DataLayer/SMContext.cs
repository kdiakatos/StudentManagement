using Microsoft.EntityFrameworkCore;
using StudentManagement.DataLayer.Entities;
using System;

namespace StudentManagement.DataLayer
{
    public class SMContext : DbContext
    {
        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<SemesterDiscipline> SemesterDisciplines { get; set; }
        public DbSet<StudentDiscipline> StudentDisciplines { get; set; }
        public DbSet<StudentSemester> StudentSemesters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>().HasData(new Student
            {
                StudentId = Guid.Parse("3FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 1, 1),
            }
            );
            builder.Entity<Student>().HasData(new Student
            {
                StudentId = Guid.Parse("1FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = new DateTime(2001, 1, 1),
            }
            );

            builder.Entity<Semester>().HasData(new Semester
            {
                SemesterId = Guid.Parse("20E30074-7687-4101-4F07-08D8CB80E9B4"),
                Name = "Semester 1",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 1, 31)
            }
            );
            builder.Entity<Semester>().HasData(new Semester
            {
                SemesterId = Guid.Parse("E759923C-D499-4548-4F08-08D8CB80E9B4"),
                Name = "Semester 2",
                StartDate = new DateTime(2021, 2, 1),
                EndDate = new DateTime(2021, 2, 28)
            }
            );

            builder.Entity<Discipline>().HasData(new Discipline
            {
                DisciplineId = Guid.Parse("A2B07A95-F621-47BB-4DA4-08D8CB7C4D1A"),
                DisciplineName = "Architecture 101",
                ProfesorName = "Ted Mosby"
            }
            );
            builder.Entity<Discipline>().HasData(new Discipline
            {
                DisciplineId = Guid.Parse("4EB64DFD-258B-4A90-9334-9D5AE32B6B5F"),
                DisciplineName = "Math 102",
                ProfesorName = "Barney Stinson"
            }
            );

            builder.Entity<SemesterDiscipline>().HasData(new SemesterDiscipline
            {
                DisciplineId = Guid.Parse("A2B07A95-F621-47BB-4DA4-08D8CB7C4D1A"),
                SemesterId = Guid.Parse("20E30074-7687-4101-4F07-08D8CB80E9B4"),
                Id = Guid.Parse("20E30074-7687-4191-4F07-08D8CB80E9B4"),
            }
            );
            builder.Entity<SemesterDiscipline>().HasData(new SemesterDiscipline
            {
                DisciplineId = Guid.Parse("4EB64DFD-258B-4A90-9334-9D5AE32B6B5F"),
                SemesterId = Guid.Parse("20E30074-7687-4101-4F07-08D8CB80E9B4"),
                Id = Guid.Parse("20E30074-7687-4101-4F17-08D8CB80E9B4"),
            }
            );

            builder.Entity<StudentDiscipline>().HasData(new StudentDiscipline
            {                
                DisciplineId = Guid.Parse("4EB64DFD-258B-4A90-9334-9D5AE32B6B5F"),
                StudentId = Guid.Parse("1FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                Id = Guid.Parse("20E30074-7687-4001-4F07-08D8CB80E9B4"),
                Score = 4
            }
           );
            builder.Entity<StudentDiscipline>().HasData(new StudentDiscipline
            {
                DisciplineId = Guid.Parse("A2B07A95-F621-47BB-4DA4-08D8CB7C4D1A"),
                StudentId = Guid.Parse("1FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                Id = Guid.Parse("20E30074-7687-4101-4F07-08D8CB70E9B4"),
                Score = 2
            }
            );

            builder.Entity<StudentSemester>().HasData(new StudentSemester
            {
                SemesterId = Guid.Parse("20E30074-7687-4101-4F07-08D8CB80E9B4"),
                StudentId = Guid.Parse("1FA85F64-5717-4562-B3FC-2C963F66AFA6"),
                Id = Guid.Parse("20E30074-7687-4101-4F07-08D8CB80E9C4"),
            }
            );
           
        }
    }
}
