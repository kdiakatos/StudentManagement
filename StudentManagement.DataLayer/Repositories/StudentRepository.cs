using Microsoft.EntityFrameworkCore;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SMContext _smContext;

        public StudentRepository(SMContext smContext)
        {
            _smContext = smContext;
        }

        public async Task<Student> CreateStudentAsynd(Student student)
        {
            await _smContext.AddAsync(student);
            await _smContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            var dbRecord = await _smContext.Students.FirstOrDefaultAsync(x => x.StudentId == student.StudentId);
            if (dbRecord != null)
            {
                dbRecord.FirstName = student.FirstName;
                dbRecord.LastName = student.LastName;
                dbRecord.DateOfBirth = student.DateOfBirth;
                await _smContext.SaveChangesAsync();
            }
            return student;
        }

        public async Task<Student> GetStudentByIdAsync(Guid id)
        {
            return await _smContext.Students.Include(x => x.StudentDisciplines).Include(x => x.StudentSemesters).FirstOrDefaultAsync(x => x.StudentId == id);
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            var dbRecord = await _smContext.Students.FirstOrDefaultAsync(x => x.StudentId == id);
            _smContext.Remove(dbRecord);
            await _smContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await _smContext.Students.Include(x => x.StudentDisciplines).Include(x => x.StudentSemesters).ToListAsync();
        }
    }
}
