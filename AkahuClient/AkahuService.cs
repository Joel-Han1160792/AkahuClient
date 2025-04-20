using System.Net;
using System.Text.Json;
using AkahuClient.Configurations;
using AkahuClient.Models.Accounts;
using AkahuClient.Models.Transfers;


namespace AkahuClient;

public class AkahuService(HttpClient httpClient, AkahuEndpoint endpoint) : IAkahuService
{
    public async Task<AccountResponse> ListAccountsAsync()
    {
        var response = await httpClient.GetAsync(endpoint.Account);
        try{
            response.EnsureSuccessStatusCode();
        }catch(HttpRequestException e)
        {
            if (e.StatusCode == HttpStatusCode.NotFound){
                // logger.LogWarning("xxx not found with");
                throw;
            }
        }
        var content = await response.Content.ReadAsStringAsync();
        
        var account = JsonSerializer.Deserialize<AccountResponse>(content, AkahuJsonSerializerConfiguration.Options);

        return account!;
    }

    public Task<TransferResponse> TransferAsync(Account from, Account to, decimal amount)
    {
        throw new NotImplementedException();
    }
}