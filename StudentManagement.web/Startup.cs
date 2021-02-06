using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using StudentManagement.BusinessLayer.Interfaces;
using StudentManagement.BusinessLayer.Services;
using StudentManagement.BusinessLayer.Utilities;
using StudentManagement.DataLayer;
using StudentManagement.DataLayer.Interfaces;
using StudentManagement.DataLayer.Repositories;

namespace StudentManagement.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SMContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<IDisciplineRepository, DisciplineRepository>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISemesterService, SemesterService>();
            services.AddScoped<IDisciplineService, DisciplineService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StudentManagement.web", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentManagement.web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
