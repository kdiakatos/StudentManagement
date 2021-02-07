using System;

namespace StudentManagement.Client.Models
{
    public class SemesterDisciplineViewModel
    {
        public Guid Id { get; set; }
        public SemesterViewModel Semester { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineViewModel Discipline { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
