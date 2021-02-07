using AutoMapper;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Models;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<StudentModel> CreateStudentAsync(StudentModel student)
        {
            var studentEntity = _mapper.Map<Student>(student);
            var result = await _studentRepository.CreateStudentAsynd(studentEntity);
            student = _mapper.Map<StudentModel>(result);
            return student;
        }

        public async Task<StudentModel> UpdateStudentAsync(StudentModel student)
        {
            var studentEntity = _mapper.Map<Student>(student);
            await _studentRepository.UpdateStudentAsync(studentEntity);
            return student;
        }

        public async Task<StudentModel> GetStudentByIdAsync(Guid id)
        {
            var result = await _studentRepository.GetStudentByIdAsync(id);
            return _mapper.Map<StudentModel>(result);
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            await _studentRepository.DeleteStudentAsync(id);
        }

        public async Task<List<StudentModel>> GetAllStudentAsync()
        {
            return _mapper.Map<List<StudentModel>>(await _studentRepository.GetAllStudentAsync());
        }

        public async Task<StudentSemesterModel> CreateStudentSemesterAsync(StudentSemesterModel studentSemester)
        {
            var studentSemesterEntity = _mapper.Map<StudentSemester>(studentSemester);
            var result = await _studentRepository.CreateStudentSemesterAsync(studentSemesterEntity);
            studentSemester = _mapper.Map<StudentSemesterModel>(result);
            return studentSemester;
        }
    }
}
