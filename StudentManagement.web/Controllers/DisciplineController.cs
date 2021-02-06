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
        public Task<List<DisciplineModel>> Get()
        {
            return _disciplineService.GetAllDisciplineAsync();
             
        }

        // GET api/<DisciplineController>/5
        [HttpGet("{id}")]
        public Task<DisciplineModel> Get(Guid id)
        {
            return _disciplineService.GetDisciplineByIdAsync(id);
        }

        // POST api/<DisciplineController>
        [HttpPost]
        public void Post([FromBody] DisciplineModel discipline)
        {
            _disciplineService.CreateDisciplineAsync(discipline);
        }

        // PUT api/<DisciplineController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] DisciplineModel discipline)
        {
            _disciplineService.UpdateDisciplineAsync(discipline);
        }

        // DELETE api/<DisciplineController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _disciplineService.DeleteDisciplineAsync(id);
        }
    }
}
