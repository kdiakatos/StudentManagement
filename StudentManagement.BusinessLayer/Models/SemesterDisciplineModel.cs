using System;

namespace StudentManagement.BusinessLayer.Models
{
    public class SemesterDisciplineModel
    {
        public Guid Id { get; set; }
        public SemesterModel SemesterModel { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineModel DisciplineModel { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
