using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Interfaces
{
    public interface IDisciplineService
    {
        Task<DisciplineModel> CreateDisciplineAsync(DisciplineModel discipline);
        Task DeleteDisciplineAsync(Guid id);
        Task<List<DisciplineModel>> GetAllDisciplineAsync();
        Task<DisciplineModel> GetDisciplineByIdAsync(Guid id);
        Task<DisciplineModel> UpdateDisciplineAsync(DisciplineModel discipline);
    }
}