﻿using System;

namespace StudentManagement.Client.Models
{
    public class StudentSemesterViewModel
    {
        public Guid Id { get; set; }
        public StudentViewModel Student { get; set; }
        public Guid StudentId { get; set; }
        public SemesterViewModel Semester { get; set; }
        public Guid SemesterId { get; set; }
    }
}
