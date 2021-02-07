using System;
using System.Collections.Generic;

namespace StudentManagement.DataLayer.Entities
{
    public class Semester
    {
        public Guid SemesterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<SemesterDiscipline> SemesterDisciplines { get; set; } = new List<SemesterDiscipline>();
        public ICollection<StudentSemester> StudentSemesters { get; set; } = new List<StudentSemester>();
    }
}
