using AutoMapper;
using StudentApi.Application.Features.Course.Commands.DTOs;
using StudentApi.Application.Features.Course.Queries.DTOs;
using StudentsApi.Domain.Entities;

namespace StudentApi.Application.MappingProfiles;

public class CourseProfile : Profile
{
     public CourseProfile()
     {
          CreateMap<CourseDto, Course>().ReverseMap();
          CreateMap<UpsertCourseDto, Course>();
     }
}