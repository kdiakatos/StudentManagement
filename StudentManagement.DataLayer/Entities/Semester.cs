using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.DataLayer.Entities
{
    public class Semester
    {
        public Guid SemesterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<SemesterDiscipline> SemesterDisciplines { get; set; }
        public ICollection<StudentSemester> StudentSemesters { get; set; }
    }
}
