﻿using System;
using System.Collections.Generic;

namespace StudentManagement.DataLayer.Entities
{
    public class Discipline
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string ProfesorName { get; set; }
        public ICollection<SemesterDiscipline> SemesterDisciplines { get; set; } = new List<SemesterDiscipline>();
        public ICollection<StudentDiscipline> StudentDisciplines { get; set; } = new List<StudentDiscipline>();
    }
}
