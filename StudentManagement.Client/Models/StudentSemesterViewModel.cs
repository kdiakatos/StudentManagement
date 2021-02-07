using System;

namespace StudentManagement.Client.Models
{
    public class StudentSemesterViewModel
    {
        public Guid Id { get; set; }
        public StudentViewModel StudentModel { get; set; }
        public Guid StudentId { get; set; }
        public SemesterViewModel SemesterModel { get; set; }
        public Guid SemesterId { get; set; }
    }
}
