using System;

namespace StudentManagement.BusinessLayer.Models
{
    public class StudentSemesterModel
    {
        public Guid Id { get; set; }
        public StudentModel Student { get; set; }
        public Guid StudentId { get; set; }
        public SemesterModel Semester { get; set; }
        public Guid SemesterId { get; set; }
    }
}
