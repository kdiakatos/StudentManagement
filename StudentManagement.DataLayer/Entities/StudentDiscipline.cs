using System;

namespace StudentManagement.DataLayer.Entities
{
    public class StudentDiscipline
    {
        public Guid Id { get; set; }
        public Student Student { get; set; }
        public Guid StudentId { get; set; }
        public Discipline Discipline { get; set; }
        public Guid DisciplineId { get; set; }
        public double Score { get; set; }
    }
}
