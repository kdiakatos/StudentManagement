using Microsoft.AspNetCore.Mvc;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService _semesterService;

        public SemesterController(ISemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        [HttpGet]
        public async Task<List<SemesterModel>> GetGetAsync()
        {
            return await _semesterService.GetAllSemesterAsync();
        }

        [HttpGet("{id}")]
        public async Task<SemesterModel> GetAsync(Guid id)
        {
            return await _semesterService.GetSemesterByIdAsync(id);
        }

        [HttpPost]
        public async Task PostAsync([FromBody] SemesterModel semesterModel)
        {
            await _semesterService.CreateSemesterAsync(semesterModel);
        }

        [HttpPut]
        public async Task PutAsync([FromBody] SemesterModel semesterModel)
        {
            await _semesterService.UpdateSemesterAsync(semesterModel);
        }

        [HttpDelete("{id}")]
        public async Task DeleteASync(Guid id)
        {
            await _semesterService.DeleteSemesterAsync(id);
        }

        [HttpGet]
        [Route("Student/{id}")]
        public async Task<List<SemesterModel>> GetSemesterByUserAsync(Guid id)
        {
            return await _semesterService.GetAllSemestersByStudentAsync(id);
        }
    }
}
