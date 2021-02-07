using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.BusinessLayer.Models
{
    public class DisciplineModel
    {
        public Guid DisciplineId { get; set; }
        [DisplayName("Discipline Name")]
        [Required]
        public string DisciplineName { get; set; }
        [DisplayName("Profesor Name")]
        [Required]
        public string ProfesorName { get; set; }
        [Required]
        public int Score { get; set; }
        public ICollection<SemesterDisciplineModel> SemesterDisciplines { get; set; } = new List<SemesterDisciplineModel>();
    }
}
