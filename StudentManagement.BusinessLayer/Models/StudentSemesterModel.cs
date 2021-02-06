using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.BusinessLayer.Models
{
    public class StudentSemesterModel
    {
        public Guid Id { get; set; }
        public StudentModel StudentModel { get; set; }
        public Guid StudentId { get; set; }
        public SemesterModel SemesterModel { get; set; }
        public Guid SemesterId { get; set; }
    }
}
