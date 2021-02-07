using System;

namespace StudentManagement.Client.Models
{
    public class SemesterDisciplineViewModel
    {
        public Guid Id { get; set; }
        public SemesterViewModel SemesterModel { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineViewModel DisciplineModel { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
