using System.Text.Json;
using System.Text.Json.Serialization;
using AkahuClient.Configurations;
using AkahuClient.Extensions;
using AkahuClient.Models.Accounts;
using AkahuClient.Models.Accounts.Enums;
using AkahuClient.Models.Commons.Enums;

namespace AkahuClient;

public class AkahuService(HttpClient httpClient) : IAkahuService
{
    public async Task<IEnumerable<Account>?> ListAccountsAsync()
    {
        var response = await httpClient.GetAsync(Endpoint.Account);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        if (content.IsNullOrEmpty())
            throw new HttpRequestException(
                HttpRequestError.InvalidResponse,
                "Account cannot be found");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var enumTypes = new[]
        {
            typeof(AccountType),
            typeof(AccountStatus),
            typeof(AccountAttribute),
            typeof(Currency)
        };

        foreach (var enumType in enumTypes)
        {
            var converterType = typeof(CaseInsensitiveEnumConverter<>).MakeGenericType(enumType);
            var converterInstance = (JsonConverter)Activator.CreateInstance(converterType)!;
            options.Converters.Add(converterInstance);
        }

        var account = JsonSerializer.Deserialize<AccountResponse>(content, options);

        if (account is null || account.HasEmptyItem())  
            throw new HttpRequestException(HttpRequestError.InvalidResponse, "Account cannot be found");

        return account!.Items;
    }
}