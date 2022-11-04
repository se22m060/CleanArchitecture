using se22m060_swe_ca.Application.Common.Interfaces;
using se22m060_swe_ca.Infrastructure.Files;
using se22m060_swe_ca.Infrastructure.Persistence;
using se22m060_swe_ca.Infrastructure.Persistence.Interceptors;
using se22m060_swe_ca.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<AuditableEntitySaveChangesInterceptor>();

        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("se22m060_swe_caDb"));

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<ApplicationDbContextInitialiser>();


        services.AddTransient<IDateTime, DateTimeService>();
        //services.AddTransient<IIdentityService, IdentityService>();
        services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = "Anonymous";
            options.DefaultChallengeScheme = "Anonymous";
            options.DefaultScheme = "Anonymous";
        });

        services.AddAuthorization(options =>
            options.AddPolicy("CanPurge", policy => policy.RequireRole("Administrator")));

        return services;
    }
}
