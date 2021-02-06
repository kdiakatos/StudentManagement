using StudentManagement.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Interfaces
{
    public interface IDisciplineRepository
    {
        Task<Discipline> CreateDisciplineAsynd(Discipline discipline);
        Task DeleteDisciplineAsync(Guid id);
        Task<Discipline> GetDisciplineByIdAsync(Guid id);
        Task<Discipline> UpdateDisciplineAsync(Discipline discipline);
        Task<List<Discipline>> GetAllDisciplineAsync();
    }
}