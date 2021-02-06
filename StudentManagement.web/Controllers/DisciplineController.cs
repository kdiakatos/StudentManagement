using Microsoft.AspNetCore.Mvc;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineService _disciplineService;

        public DisciplineController(IDisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }


        // GET: api/<DisciplineController>
        [HttpGet]
        public async Task<List<DisciplineModel>> GetAsync()
        {
            return await _disciplineService.GetAllDisciplineAsync();
             
        }

        // GET api/<DisciplineController>/5
        [HttpGet("{id}")]
        public async Task<DisciplineModel> GetAsync(Guid id)
        {
            return await _disciplineService.GetDisciplineByIdAsync(id);
        }

        // POST api/<DisciplineController>
        [HttpPost]
        public async Task PostAsync([FromBody] DisciplineModel discipline)
        {
           await _disciplineService.CreateDisciplineAsync(discipline);
        }

        // PUT api/<DisciplineController>/5
        [HttpPut("{id}")]
        public async Task PutAsync([FromBody] DisciplineModel discipline)
        {
           await _disciplineService.UpdateDisciplineAsync(discipline);
        }

        // DELETE api/<DisciplineController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
           await _disciplineService.DeleteDisciplineAsync(id);
        }
    }
}
