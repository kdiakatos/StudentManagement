using AutoMapper;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Models;
using StudentManagement.DataLayer.Entities;
using StudentManagement.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly IMapper _mapper;

        public DisciplineService(IMapper mapper, IDisciplineRepository disciplineRepository)
        {
            _mapper = mapper;
            _disciplineRepository = disciplineRepository;
        }

        public async Task<DisciplineModel> CreateDisciplineAsync(DisciplineModel discipline)
        {
            var disciplineEntity = _mapper.Map<Discipline>(discipline);
            var result = await _disciplineRepository.CreateDisciplineAsynd(disciplineEntity);
            discipline = _mapper.Map<DisciplineModel>(result);
            return discipline;
        }

        public async Task<DisciplineModel> UpdateDisciplineAsync(DisciplineModel discipline)
        {
            var saleEntity = _mapper.Map<Discipline>(discipline);
            await _disciplineRepository.UpdateDisciplineAsync(saleEntity);
            return discipline;
        }

        public async Task<DisciplineModel> GetDisciplineByIdAsync(Guid id)
        {
            var result = await _disciplineRepository.GetDisciplineByIdAsync(id);
            return _mapper.Map<DisciplineModel>(result);
        }

        public async Task DeleteDisciplineAsync(Guid id)
        {
            await _disciplineRepository.DeleteDisciplineAsync(id);
        }

        public async Task<List<DisciplineModel>> GetAllDisciplineAsync()
        {
            return _mapper.Map<List<DisciplineModel>>(await _disciplineRepository.GetAllDisciplineAsync());
        }
    }
}
