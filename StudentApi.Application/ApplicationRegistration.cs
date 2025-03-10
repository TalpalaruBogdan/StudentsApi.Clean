using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace StudentApi.Application;

public static class ApplicationRegistration
{
     public static IServiceCollection AddApplicationServices(this IServiceCollection services)
     {
          services.AddAutoMapper(Assembly.GetExecutingAssembly());
          services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
          return services;
     }
}