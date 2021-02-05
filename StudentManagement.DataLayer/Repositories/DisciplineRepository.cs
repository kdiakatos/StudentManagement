using Microsoft.EntityFrameworkCore;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Repositories
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly SMContext _smContext;

        public DisciplineRepository(SMContext smContext)
        {
            _smContext = smContext;
        }

        public async Task<Discipline> CreateDisciplineAsynd(Discipline discipline)
        {
            await _smContext.AddAsync(discipline);
            await _smContext.SaveChangesAsync();
            return discipline;
        }

        public async Task<Discipline> UpdateDisciplineAsync(Discipline discipline)
        {
            var dbRecord = await _smContext.Disciplines.FirstOrDefaultAsync(x => x.DisciplineId == discipline.DisciplineId);
            if (dbRecord != null)
            {
                dbRecord.DisciplineName = discipline.DisciplineName;
                dbRecord.ProfesorName = discipline.ProfesorName;
                await _smContext.SaveChangesAsync();
            }
            return discipline;
        }

        public async Task<Discipline> GetDisciplineByIdAsync(Guid id)
        {
            return await _smContext.Disciplines.FirstOrDefaultAsync(x => x.DisciplineId == id);
        }

        public async Task DeleteDisciplineAsync(Guid id)
        {
            var dbRecord = await _smContext.Disciplines.FirstOrDefaultAsync(x => x.DisciplineId == id);
            _smContext.Remove(dbRecord);
            await _smContext.SaveChangesAsync();
        }
    }
}
