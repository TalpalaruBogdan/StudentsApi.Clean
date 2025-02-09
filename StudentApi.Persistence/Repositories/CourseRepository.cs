using Microsoft.EntityFrameworkCore;
using StudentApi.Application.Contracts.Persistence;
using StudentApi.Persistence.DatabaseContexts;
using StudentsApi.Domain.Entities;

namespace StudentApi.Persistence.Repositories;

public class CourseRepository : ICourseRepository
{
     private readonly DataContext _context;

     public CourseRepository(DataContext context)
     {
          _context = context;
     }
     
     public async Task<Course?> GetById(Guid id)
     {
          return await _context.Courses.FindAsync(id);
     }

     public async Task<IReadOnlyList<Course>> GetAll()
     {
          return await _context.Courses.AsNoTracking().ToListAsync();
     }

     public async Task<Course> Add(Course entity)
     {
          await _context.Courses.AddAsync(entity);
          await _context.SaveChangesAsync();
          return entity;
     }

     public async Task Update(Guid id, Course entity)
     {
          var foundCourse = await _context.Courses.FindAsync(id);
          if (foundCourse != null)
          {
               _context.Entry(foundCourse).CurrentValues.SetValues(entity);
               await _context.SaveChangesAsync();
          }
     }

     public async Task Delete(Guid id)
     {
          var foundCourse = await _context.Courses.FindAsync(id);
          if (foundCourse != null)
          {
               _context.Courses.Remove(foundCourse);
               await _context.SaveChangesAsync();
          }
     }

     public async Task<Course?> GetCourseByName(string name)
     {
          return await _context.Courses.FirstOrDefaultAsync(x => x.CourseName!.Equals(name));
     }

     public async Task<bool> IsUnique(string name)
     {
         var entry = await GetCourseByName(name);
         return entry != null;
     }
}