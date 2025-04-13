using System.Text.Json;
using System.Text.Json.Serialization;
using AkahuClient.Models.Accounts;
using AkahuClient.Models.Accounts.Enums;
using AkahuClient.Models.General.Enums;

namespace AkahuClient;

public class AkahuService: IAkahuService
{
    private readonly HttpClient _httpClient;

    public AkahuService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Account>> ListAccountsAsync()
    {
        HttpResponseMessage response = await _httpClient.GetAsync(Endpoint.Account);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        if (content is null || content == string.Empty) 
            // TODO Other exeception for HTTP 404? Not null reference because it feels like a 500x error inside programme.
            throw new NullReferenceException("Account cannot be found.");
        
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
            var converterInstance = (JsonConverter)Activator.CreateInstance(converterType);
            options.Converters.Add(converterInstance);
        }
        var account = JsonSerializer.Deserialize<AccountResponse>(content, options);
        
        // TODO Success is from AkahuResponseBase, does anyone else use it on Github?
        // if (!user.Success) throw new KeyNotFoundException("User is not found.");

        return account!.Items;
    }
}