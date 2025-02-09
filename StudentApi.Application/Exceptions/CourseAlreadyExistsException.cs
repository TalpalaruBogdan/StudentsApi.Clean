namespace StudentApi.Application.Exceptions;

public class CourseAlreadyExistsException : Exception
{
     public CourseAlreadyExistsException(string name, object key) : base($"Course {name} ({key}) already exists")
     {
          
     }
}