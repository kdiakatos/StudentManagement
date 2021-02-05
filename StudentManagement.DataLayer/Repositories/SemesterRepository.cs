using Microsoft.EntityFrameworkCore;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Repositories
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly SMContext _smContext;

        public SemesterRepository(SMContext smContext)
        {
            _smContext = smContext;
        }

        public async Task<Semester> CreateSemesterAsynd(Semester semester)
        {
            await _smContext.AddAsync(semester);
            await _smContext.SaveChangesAsync();
            return semester;
        }

        public async Task<Semester> UpdateSemesterAsync(Semester semester)
        {
            var dbRecord = await _smContext.Semesters.FirstOrDefaultAsync(x => x.SemesterId == semester.SemesterId);
            if (dbRecord != null)
            {
                dbRecord.Name = semester.Name;
                dbRecord.StartDate = semester.StartDate;
                dbRecord.EndDate = semester.EndDate;
                await _smContext.SaveChangesAsync();
            }
            return semester;
        }

        public async Task<Semester> GetSemesterByIdAsync(Guid id)
        {
            return await _smContext.Semesters.FirstOrDefaultAsync(x => x.SemesterId == id);
        }

        public async Task DeleteSemesterAsync(Guid id)
        {
            var dbRecord = await _smContext.Semesters.FirstOrDefaultAsync(x => x.SemesterId == id);
            _smContext.Remove(dbRecord);
            await _smContext.SaveChangesAsync();
        }
    }
}
