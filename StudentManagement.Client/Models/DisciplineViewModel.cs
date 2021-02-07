using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Client.Models
{
    public class DisciplineViewModel
    {
        public Guid DisciplineId { get; set; }
        [DisplayName("Name")]
        [Required]
        public string DisciplineName { get; set; }
        [DisplayName("Profesor")]
        [Required]
        public string ProfesorName { get; set; }
        [DisplayName("Score")]
        [Required]
        public int Score { get; set; }
        //public ICollection<SemesterDisciplineViewModel> SemesterDisciplineModels { get; set; }
    }
}
