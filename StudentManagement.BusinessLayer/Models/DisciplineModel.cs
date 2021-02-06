using System;
using System.Collections.Generic;

namespace StudentManagement.BusinessLayer.Models
{
    public class DisciplineModel
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string ProfesorName { get; set; }
        public int Score { get; set; }
        public ICollection<SemesterDisciplineModel> SemesterDisciplineModels { get; set; }
    }
}
