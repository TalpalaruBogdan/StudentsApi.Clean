using StudentsApi.Domain.Entities;

namespace StudentApi.Application.Contracts.Persistence;

public interface IStudentRepository : IGenericRepository<Student>
{
}