using StudentsApi.Domain.Entities;

namespace StudentApi.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
     Task<T> GetById(Guid id);
     
     Task<IReadOnlyList<T>> GetAll();
     
     Task<T> Add(T entity);
     
     Task<T> Update(Guid Id, T entity);
     
     Task Delete(Guid id);
}