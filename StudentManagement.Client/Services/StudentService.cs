using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StudentManagement.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentManagement.Client.Services
{
    public class StudentService
    {
        public HttpClient Client { get; }

        private readonly IConfiguration _configuration;

        public StudentService(HttpClient client, IConfiguration configuration)
        {
            _configuration = configuration;
            var baseUrl = configuration.GetValue<string>("HttpClientSettings:BaseURL");
            client.BaseAddress = new Uri(baseUrl);
            Client = client;
        }

        public async Task<List<StudentViewModel>> GetStudentListAsync()
        {
            var studentsList = new List<StudentViewModel>();
            try
            {

                var response = await Client.GetAsync("api/student");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<StudentViewModel>>(jsonResponse, options);
                    studentsList = result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return studentsList;
        }

        public async Task<StudentViewModel> GetStudentByIdAsync(Guid studentId)
        {
            var student = new StudentViewModel();
            try
            {
                var response = await Client.GetAsync("api/student/" + studentId);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    student = System.Text.Json.JsonSerializer.Deserialize<StudentViewModel>(jsonResponse, options);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public async Task<StudentViewModel> AddStudentAsync(StudentViewModel student)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(student);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PostAsync("api/student", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public async Task<StudentViewModel> UpdateStudentAsync(StudentViewModel student)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(student);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PutAsync("api/student", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }
    }
}
