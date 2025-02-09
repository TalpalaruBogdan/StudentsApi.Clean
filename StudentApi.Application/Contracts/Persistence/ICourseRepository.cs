using StudentsApi.Domain.Entities;

namespace StudentApi.Application.Contracts.Persistence;

public interface ICourseRepository : IGenericRepository<Course>
{
     public Task<Course> GetCourseByName(string name);
}