using StudentManagement.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.Text;
using Newtonsoft.Json;

namespace StudentManagement.Client.Services
{
    public class DisciplineService
    {
        public HttpClient Client { get; }

        private readonly IConfiguration _configuration;

        public DisciplineService(HttpClient client, IConfiguration configuration)
        {
            _configuration = configuration;
            var baseUrl = configuration.GetValue<string>("HttpClientSettings:BaseURL");
            client.BaseAddress = new Uri(baseUrl);
            Client = client;
        }

        public async Task<List<DisciplineViewModel>> GetDisciplineListAsync()
        {
            var disciplinesList = new List<DisciplineViewModel>();
            try
            {

                var response = await Client.GetAsync("api/discipline");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<DisciplineViewModel>>(jsonResponse, options);
                    disciplinesList = result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return disciplinesList;
        }

        public async Task<DisciplineViewModel> GetDisciplineByIdAsync(Guid disciplineId)
        {
            var discipline = new DisciplineViewModel();
            try
            {
                var response = await Client.GetAsync("api/discipline/" + disciplineId);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    discipline = System.Text.Json.JsonSerializer.Deserialize<DisciplineViewModel>(jsonResponse, options);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return discipline;
        }

        public async Task<DisciplineViewModel> AddDisciplineAsync(DisciplineViewModel discipline)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(discipline);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PostAsync("api/discipline", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return discipline;
        }

        public async Task<DisciplineViewModel> UpdateDisciplineAsync(DisciplineViewModel discipline)
        {
            try
            {
                var jsonPayload = JsonConvert.SerializeObject(discipline);
                var body = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await Client.PutAsync("api/discipline", body);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return discipline;
        }
    }
}
