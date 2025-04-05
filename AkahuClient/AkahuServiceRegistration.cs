using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

public static class ServiceRegistration
{
    public static IServiceCollection AddMyHttpClientService(
        this IServiceCollection services, 
        Action<Token> configureToken
    )
    {
        var token = new Token();
        configureToken(token);

        services.AddSingleton(token); 

        services.AddHttpClient<IAkahuService, AkahuService>((serviceProvider, client) =>
        {
            var token = serviceProvider.GetRequiredService<Token>();

            // TODO 检查 http client 信息是否正确配置
            client.BaseAddress = new Uri(Endpoint.BaseUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.UserToken);
            client.DefaultRequestHeaders.Add("X-Akahu-Id", token.AppToken);
            client.DefaultRequestHeaders.Add("Host", Endpoint.Host);
        });

        return services;
    }
}
