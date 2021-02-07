using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Client.Models
{
    public class StudentViewModel
    {
        public Guid StudentId { get; set; }
        [DisplayName("First Name")]
        [Required]

        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]

        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        [Required]

        public DateTime DateOfBirth { get; set; }

        public ICollection<StudentSemesterViewModel> StudentSemesters { get; set; }
    }
}
