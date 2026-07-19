using Microsoft.Extensions.DependencyInjection;
using SAAP.Educational.Domain.Courses;
using SAAP.Educational.Infrastructure.Persistence;
using SAAP.Educational.Infrastructure.Persistence.Courses;
using SAAP.Educational.Shared.Persistence;

namespace SAAP.Educational.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<CourseStorage>();
        services.AddScoped<IQueryRepository<Course, Guid>, InMemoryCourseQueryRepository>();
        services.AddScoped<ICommandRepository<Course, Guid>, InMemoryCourseCommandRepository>();

        return services;
    }
}
