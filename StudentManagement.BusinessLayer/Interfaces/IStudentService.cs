using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        Task<StudentModel> CreateSemesterAsync(StudentModel student);
        Task DeleteSemesterAsync(Guid id);
        Task<List<StudentModel>> GetAllSemesterAsync();
        Task<StudentModel> GetSemesterByIdAsync(Guid id);
        Task<StudentModel> UpdateSemesterAsync(StudentModel student);
    }
}