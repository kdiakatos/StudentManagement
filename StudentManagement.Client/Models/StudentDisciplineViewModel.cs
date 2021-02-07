using System;

namespace StudentManagement.Client.Models
{
    public class StudentDisciplineViewModel
    {
        public Guid Id { get; set; }
        public SemesterViewModel Semester { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineViewModel Discipline { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
