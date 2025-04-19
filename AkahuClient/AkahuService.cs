using System.Text.Json;
using AkahuClient.Configurations;
using AkahuClient.Extensions;
using AkahuClient.Models.Accounts;

namespace AkahuClient;

public class AkahuService(HttpClient httpClient, AkahuEndpoint endpoint) : IAkahuService
{
    public async Task<IEnumerable<Account>?> ListAccountsAsync()
    {
        var response = await httpClient.GetAsync(endpoint.Account);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        if (content.IsNullOrEmpty())
            throw new HttpRequestException(
                HttpRequestError.InvalidResponse,
                "Account cannot be found");

        var account = JsonSerializer.Deserialize<AccountResponse>(content, AkahuJsonSerializerConfiguration.Options);

        if (account is null || account.HasEmptyItem())  
            throw new HttpRequestException(HttpRequestError.InvalidResponse, "Account cannot be found");

        return account!.Items;
    }
}