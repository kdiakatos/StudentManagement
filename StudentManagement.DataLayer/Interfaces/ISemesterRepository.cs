using StudentManagement.DataLayer.Entities;
using System;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Interfaces
{
    public interface ISemesterRepository
    {
        Task<Semester> CreateSemesterAsynd(Semester semester);
        Task DeleteSemesterAsync(Guid id);
        Task<Semester> GetSemesterByIdAsync(Guid id);
        Task<Semester> UpdateSemesterAsync(Semester semester);
    }
}