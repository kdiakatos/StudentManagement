using StudentManagement.DataLayer.Entities;
using System;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> CreateStudentAsynd(Student student);
        Task DeleteStudentAsync(Guid id);
        Task<Student> GetStudentByIdAsync(Guid id);
        Task<Student> UpdateStudentAsync(Student student);
    }
}