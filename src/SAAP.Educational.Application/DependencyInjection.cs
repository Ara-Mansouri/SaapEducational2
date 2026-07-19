using Microsoft.Extensions.DependencyInjection;
using SAAP.Educational.Application.Mediator;
using SAAP.Educational.Shared.Mediator;

namespace SAAP.Educational.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        services.AddScoped<IApplicationMediator, ApplicationMediator>();

        return services;
    }
}
