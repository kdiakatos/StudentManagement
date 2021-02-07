using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Client.Models
{
    public class SemesterViewModel
    {
        public Guid SemesterId { get; set; }
        [DisplayName("Name")]
        [Required]

        public string Name { get; set; }
        [DisplayName("Start Date")]
        [Required]

        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        [Required]

        public DateTime EndDate { get; set; }

        public ICollection<SemesterDisciplineViewModel> SemesterDisciplineModels { get; set; }

        public ICollection<StudentSemesterViewModel> StudentSemesterModels { get; set; }
    }
}
