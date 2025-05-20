using dotNetFinalProjectAPITesting.Framework.DataGenerator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace dotNetFinalProjectAPITesting;

public static class ServiceRegistry
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        var testConfig = configuration.GetSection("ApiConfig").Get<ApiConfig>();
        services.AddSingleton(testConfig);
        services.AddSingleton(new HttpClientProvider(testConfig));
        services.AddSingleton(new UserGenerator());

        return services;
    }
}