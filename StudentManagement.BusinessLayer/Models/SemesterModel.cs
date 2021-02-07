using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.BusinessLayer.Models
{
    public class SemesterModel
    {
        public Guid SemesterId { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        [Required]
        public DateTime EndDate { get; set; }
        public ICollection<SemesterDisciplineModel> SemesterDisciplines { get; set; } = new List<SemesterDisciplineModel>();
        public ICollection<StudentSemesterModel> StudentSemesters { get; set; } = new List<StudentSemesterModel>();
    }
}
