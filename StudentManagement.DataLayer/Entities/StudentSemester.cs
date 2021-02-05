using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.DataLayer.Entities
{
    public class StudentSemester
    {
        public Guid Id { get; set; }
        public Student Student { get; set; }
        public Guid StudentId { get; set; }
        public Semester Semester { get; set; }
        public Guid SemesterId { get; set; }
       
    }
}
