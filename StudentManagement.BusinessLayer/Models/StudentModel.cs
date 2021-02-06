using System;
using System.Collections.Generic;

namespace StudentManagement.BusinessLayer.Models
{
    public class StudentModel
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<StudentSemesterModel> StudentSemesterModels { get; set; }
    }
}
