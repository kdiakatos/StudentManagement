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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet]
        public async Task<List<StudentModel>> GetGetAsync()
        {
            return await _studentService.GetAllStudentAsync();
        }

        [HttpGet("{id}")]
        public async Task<StudentModel> GetAsync(Guid id)
        {
            return await _studentService.GetStudentByIdAsync(id);
        }

        [HttpPost]
        public async Task PostAsync([FromBody] StudentModel studentModel)
        {
           await _studentService.CreateStudentAsync(studentModel);
        }

        [HttpPut]
        public async Task PutAsync([FromBody] StudentModel studentModel)
        {
           await _studentService.UpdateStudentAsync(studentModel);
        }

        [HttpDelete("{id}")]
        public async Task DeleteASync(Guid id)
        {
           await _studentService.DeleteStudentAsync(id);
        }
    }
}
