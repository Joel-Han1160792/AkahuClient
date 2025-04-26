using System.Net.Http.Headers;
using System.Text.Json;
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
        #region Load Endpoint

        var endpointConfigJson = File.ReadAllText(
            Path.Combine(Directory.GetCurrentDirectory(), "akahu.config.json")
        );
        var endpoint =
            JsonSerializer.Deserialize<AkahuEndpointConfiguration>(endpointConfigJson)
            ?? new AkahuEndpointConfiguration();

        services.AddSingleton(new AkahuEndpoint(endpoint));

        #endregion

        #region Configure Akahu token

        var token = new AkahuToken();
        configureToken(token);

        services.AddSingleton(token);

        services.AddHttpClient<IAkahuService, AkahuService>((serviceProvider, client) =>
        {
            var loadedToken = serviceProvider.GetRequiredService<AkahuToken>();

            client.BaseAddress = new Uri(endpoint.Baseurl);
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", loadedToken.UserToken);
            client.DefaultRequestHeaders.Add("X-Akahu-Id", loadedToken.AppToken);
            client.DefaultRequestHeaders.Add("Host", endpoint.Host);
        });

        #endregion

        return services;
    }
}