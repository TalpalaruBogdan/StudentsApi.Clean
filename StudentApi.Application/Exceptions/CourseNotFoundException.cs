namespace StudentApi.Application.Exceptions;

public class CourseNotFoundException : Exception
{
     public CourseNotFoundException(string name, object key) : base($"Course {name} ({key}) does not exist")
     {
          
     }
}