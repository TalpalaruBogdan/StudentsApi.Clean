using AutoMapper;
using StudentsApi.Domain.Entities;

namespace StudentApi.Application.MappingProfiles;

public class StudentProfile : Profile
{
     public StudentProfile()
     {
          //CreateMap<StudentDTO, Student>().ReverseMap();
     }
}