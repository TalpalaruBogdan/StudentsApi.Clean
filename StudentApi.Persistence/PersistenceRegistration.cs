using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentApi.Persistence.DatabaseContexts;

namespace StudentApi.Persistence;

public static class PersistenceRegistration
{
     public static IServiceCollection AddPersistenceRegistration(this IServiceCollection services, IConfiguration configuration)
     {
          //TODO: Add database connection
          services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
          return services;
     }
}