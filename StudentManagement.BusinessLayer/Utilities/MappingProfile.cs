using AutoMapper;
using StudentManagement.BusinessLayer.Models;
using StudentManagement.DataLayer.Entities;

namespace StudentManagement.BusinessLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Discipline, DisciplineModel>().ReverseMap();
            CreateMap<Semester, SemesterModel>().ReverseMap();
            CreateMap<Student, StudentModel>().ReverseMap();

            CreateMap<StudentSemester, StudentSemesterModel>().ReverseMap();
            CreateMap<SemesterDiscipline, SemesterDisciplineModel>().ReverseMap();
            CreateMap<StudentDiscipline, StudentDisciplineModel>().ReverseMap();
        }
    }
}
