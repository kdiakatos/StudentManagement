using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.BusinessLayer.Models
{
    public class SemesterModel
    {
        public Guid SemesterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<SemesterDisciplineModel> SemesterDisciplineModels { get; set; }
        public ICollection<StudentSemesterModel> StudentSemesterModels { get; set; }
    }
}
