using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Interfaces
{
    public interface ISemesterService
    {
        Task<SemesterModel> CreateSemesterAsync(SemesterModel semester);
        Task DeleteSemesterAsync(Guid id);
        Task<List<SemesterModel>> GetAllSemesterAsync();
        Task<SemesterModel> GetSemesterByIdAsync(Guid id);
        Task<SemesterModel> UpdateSemesterAsync(SemesterModel semester);
        Task<List<SemesterModel>> GetAllSemestersByStudentAsync(Guid studentId);
    }
}