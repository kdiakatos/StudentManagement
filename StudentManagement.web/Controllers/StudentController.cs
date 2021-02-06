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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        // GET: api/<StudentController>
        [HttpGet]
        public async Task<List<StudentModel>> GetGetAsync()
        {
            return await _studentService.GetAllStudentAsync();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<StudentModel> GetAsync(Guid id)
        {
            return await _studentService.GetStudentByIdAsync(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task PostAsync([FromBody] StudentModel studentModel)
        {
           await _studentService.CreateStudentAsync(studentModel);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task PutAsync([FromBody] StudentModel studentModel)
        {
           await _studentService.UpdateStudentAsync(studentModel);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task DeleteASync(Guid id)
        {
           await _studentService.DeleteStudentAsync(id);
        }
    }
}
