using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        Task<StudentModel> CreateStudentAsync(StudentModel student);
        Task DeleteStudentAsync(Guid id);
        Task<List<StudentModel>> GetAllStudentAsync();
        Task<StudentModel> GetStudentByIdAsync(Guid id);
        Task<StudentModel> UpdateStudentAsync(StudentModel student);
    }
}