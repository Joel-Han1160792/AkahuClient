using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AkahuClient.Models.Accounts;

internal class AkahuService: IAkahuService
{
    private readonly HttpClient _httpClient;

    public AkahuService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Account> GetAccountAsync()
    {
        HttpResponseMessage response = await _httpClient.GetAsync(Endpoint.Account);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        if (content is null || content == string.Empty) 
            // TODO Other exeception for HTTP 404? Not null reference because it feels like a 500x error inside programme.
            throw new NullReferenceException("Account cannot be found.");

        var account = JsonSerializer.Deserialize<Account>(content);
        
        // TODO Success is from AkahuResponseBase, does anyone else use it on Github?
        // if (!user.Success) throw new KeyNotFoundException("User is not found.");

        return account!;
    }
}
