using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.BusinessLayer.Models
{
    public class StudentDisciplineModel
    {
        public Guid Id { get; set; }
        public SemesterModel Semester { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineModel Discipline { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
