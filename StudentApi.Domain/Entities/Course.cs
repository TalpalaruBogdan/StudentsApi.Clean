using StudentsApi.Domain.Enums;

namespace StudentsApi.Domain.Entities;

public class Course : BaseEntity
{
     public string? CourseName { get; set; }

     public string? CourseDescription { get; set; }
     
     public double CoursePrice { get; set; }
     
     public CourseType CourseType { get; set; }

     public List<CourseModule>? CourseModules { get; set; } = new ();
}