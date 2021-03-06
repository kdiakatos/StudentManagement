﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.BusinessLayer.Models
{
    public class StudentModel
    {
        public Guid StudentId { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Full Name")]
        public string FullName => FirstName + " " + LastName;
        [DisplayName("Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        public ICollection<StudentSemesterModel> StudentSemesters { get; set; } = new List<StudentSemesterModel>();
    }
}
