using Microsoft.EntityFrameworkCore;
using StudentManagement.DataLayer.Entities;

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
    }
}
