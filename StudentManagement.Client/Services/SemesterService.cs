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
    public class SemesterService
    {
        public HttpClient Client { get; }

        private readonly IConfiguration _configuration;

        public SemesterService(HttpClient client, IConfiguration configuration)
        {
            _configuration = configuration;
            var baseUrl = configuration.GetValue<string>("HttpClientSettings:BaseURL");
            client.BaseAddress = new Uri(baseUrl);
            Client = client;
        }

        public async Task<List<SemesterViewModel>> GetSemestersListAsync()
        {
            var semestersList = new List<SemesterViewModel>();
            try
            {

                var response = await Client.GetAsync("api/semester");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<SemesterViewModel>>(jsonResponse, options);
                    semestersList = result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semestersList;
        }

        public async Task<SemesterViewModel> GetSemesterByIdAsync(Guid semesterId)
        {
            var semester = new SemesterViewModel();
            try
            {
                var response = await Client.GetAsync("api/semester/" + semesterId);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    semester = System.Text.Json.JsonSerializer.Deserialize<SemesterViewModel>(jsonResponse, options);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semester;
        }

        public async Task<SemesterViewModel> AddSemesterAsync(SemesterViewModel semester)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(semester);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PostAsync("api/semester", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semester;
        }

        public async Task<SemesterViewModel> UpdateSemesterAsync(SemesterViewModel semester)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(semester);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PutAsync("api/semester", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semester;
        }

        public async Task<List<SemesterViewModel>> GetSemestersByStudentListAsync(Guid studentId)
        {
            var semestersList = new List<SemesterViewModel>();
            try
            {

                var response = await Client.GetAsync("api/Semester/Student/" + studentId);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<SemesterViewModel>>(jsonResponse, options);
                    semestersList = result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semestersList;
        }
    }
}
