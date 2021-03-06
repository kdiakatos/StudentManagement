﻿using System;

namespace StudentManagement.BusinessLayer.Models
{
    public class SemesterDisciplineModel
    {
        public Guid Id { get; set; }
        public SemesterModel Semester { get; set; }
        public Guid SemesterId { get; set; }
        public DisciplineModel Discipline { get; set; }
        public Guid DisciplineId { get; set; }
    }
}
