using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAAP.Educational.Modules.Identity.Infrastructure.Persistence;

namespace SAAP.Educational.Modules.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("IdentityDatabase");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException(
                "Connection string 'IdentityDatabase' is required for the Identity module.");
        }

        services.AddDbContext<IdentityDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}
