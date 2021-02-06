using System;
using System.Collections.Generic;

namespace StudentManagement.DataLayer.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<StudentSemester> StudentSemesters { get; set; }
    }
}
