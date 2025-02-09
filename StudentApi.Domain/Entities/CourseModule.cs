namespace StudentsApi.Domain.Entities;

public class CourseModule : BaseEntity
{
     public string? ModuleName { get; set; }
     
     public string? Description { get; set; }
     
     public string? Content { get; set; }

     public List<string>? Resources { get; set; }
     
     public virtual Course? Course { get; set; }
}