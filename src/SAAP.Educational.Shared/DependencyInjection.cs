using Microsoft.Extensions.DependencyInjection;
using SAAP.Educational.Shared.Mediator;

namespace SAAP.Educational.Shared;

public static class DependencyInjection
{
    public static IServiceCollection AddSharedKernel(this IServiceCollection services)
    {
        services.AddScoped<IApplicationMediator, ApplicationMediator>();
        return services;
    }
}
