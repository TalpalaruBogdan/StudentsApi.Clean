namespace StudentsApi.Domain.Entities;

public class Student : BaseEntity
{
     public string FirstName { get; set; }
     
     public string LastName { get; set; }
     
     public string Email { get; set; }
     
     public int Age { get; set; }
     
     public DateTime DateOfBirth { get; set; }
     
     public DateTime RegistrationDate { get; set; }

     public Student(string firstName, string lastName, string email, int age, DateTime dateOfBirth)
     {
          Id = Guid.NewGuid();
          FirstName = firstName;
          LastName = lastName;
          Email = email;
          Age = age;
          DateOfBirth = dateOfBirth;
          RegistrationDate = DateTime.Now;
     }
}