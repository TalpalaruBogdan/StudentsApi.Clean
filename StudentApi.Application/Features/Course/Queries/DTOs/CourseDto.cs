using StudentsApi.Domain.Entities;
using StudentsApi.Domain.Enums;

namespace StudentApi.Application.Features.Course.Queries.DTOs;

public class CourseDto
{
      public Guid Id { get; set; }
      
      public string? CourseName { get; set; }

      public string? CourseDescription { get; set; }
     
      public double CoursePrice { get; set; }
     
      public CourseType CourseType { get; set; }

      public List<CourseModule>? CourseModules { get; set; }
}