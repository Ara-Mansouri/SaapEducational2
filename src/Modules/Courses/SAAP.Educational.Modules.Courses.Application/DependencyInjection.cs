using Microsoft.Extensions.DependencyInjection;
using SAAP.Educational.Modules.Courses.Contracts;

namespace SAAP.Educational.Modules.Courses.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddCoursesApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
        services.AddScoped<ICoursesModule, CoursesModule>();

        return services;
    }
}
