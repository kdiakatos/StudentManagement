using System;

namespace StudentManagement.DataLayer.Entities
{
    public class SemesterDiscipline
    {
        public Guid Id { get; set; }
        public Semester Semester { get; set; }
        public Guid SemesterId { get; set; }
        public Discipline Discipline { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
