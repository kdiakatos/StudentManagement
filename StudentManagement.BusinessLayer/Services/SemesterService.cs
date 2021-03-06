﻿using AutoMapper;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Models;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly ISemesterRepository _semesterRepository;
        private readonly IMapper _mapper;

        public SemesterService(IMapper mapper, ISemesterRepository semesterRepository)
        {
            _mapper = mapper;
            _semesterRepository = semesterRepository;
        }

        public async Task<SemesterModel> CreateSemesterAsync(SemesterModel semester)
        {
            var semesterEntity = _mapper.Map<Semester>(semester);
            var result = await _semesterRepository.CreateSemesterAsynd(semesterEntity);
            semester = _mapper.Map<SemesterModel>(result);
            return semester;
        }

        public async Task<SemesterModel> UpdateSemesterAsync(SemesterModel semester)
        {
            var semesterEntity = _mapper.Map<Semester>(semester);
            await _semesterRepository.UpdateSemesterAsync(semesterEntity);
            return semester;
        }

        public async Task<SemesterModel> GetSemesterByIdAsync(Guid id)
        {
            var result = await _semesterRepository.GetSemesterByIdAsync(id);
            return _mapper.Map<SemesterModel>(result);
        }

        public async Task DeleteSemesterAsync(Guid id)
        {
            await _semesterRepository.DeleteSemesterAsync(id);
        }

        public async Task<List<SemesterModel>> GetAllSemesterAsync()
        {
            return _mapper.Map<List<SemesterModel>>(await _semesterRepository.GetAllSemesterAsync());
        }

        public async Task<List<SemesterModel>> GetAllSemestersByStudentAsync(Guid studentId)
        {
            var result = _mapper.Map<List<StudentSemesterModel>>(await _semesterRepository.GetAllSemestersByStudentAsync(studentId));
            var semesters = _mapper.Map<List<SemesterModel>>(await _semesterRepository.GetAllSemesterAsync());
            var finalResult = new List<SemesterModel>();
            foreach (var item in result)
            {
                var semester = new SemesterModel
                {
                    SemesterId = item.SemesterId,
                    Name = semesters.FirstOrDefault(x => x.SemesterId == item.SemesterId).Name
                };
                finalResult.Add(semester);
            }
            return finalResult;
        }
    }
}
