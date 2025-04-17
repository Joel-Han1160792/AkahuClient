using System.Net.Http.Headers;
using AkahuClient.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace AkahuClient;

public static class ServiceRegistration
{
    public static IServiceCollection AddAkahuClientService(
        this IServiceCollection services,
        Action<AkahuToken> configureToken
    )
    {
        var token = new AkahuToken();
        configureToken(token);

        services.AddSingleton(token);

        services.AddHttpClient<IAkahuService, AkahuService>((serviceProvider, client) =>
        {
            var loadedToken = serviceProvider.GetRequiredService<AkahuToken>();

            client.BaseAddress = new Uri(Endpoint.BaseUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loadedToken.UserToken);
            client.DefaultRequestHeaders.Add("X-Akahu-Id", loadedToken.AppToken);
            client.DefaultRequestHeaders.Add("Host", Endpoint.Host);
        });

        return services;
    }
}