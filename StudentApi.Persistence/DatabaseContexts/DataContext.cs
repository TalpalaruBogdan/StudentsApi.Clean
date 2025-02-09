using Microsoft.EntityFrameworkCore;
using StudentsApi.Domain.Entities;
using StudentsApi.Domain.Enums;

namespace StudentApi.Persistence.DatabaseContexts;

public class DataContext : DbContext
{
     public DataContext(DbContextOptions<DataContext> options) : base(options)
     {
          
     }
     
     public DbSet<Student> Students { get; set; }
     
     public DbSet<Course> Courses { get; set; }
     
     public DbSet<CourseModule> CourseModules { get; set; }

     public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
     {
          foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                        .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
          {
               entry.Entity.UpdatedAt = DateTime.Now;
               
               if(entry.State == EntityState.Added) 
                    entry.Entity.CreatedAt = DateTime.Now;
          }
          
          return base.SaveChangesAsync(cancellationToken);
     }
}