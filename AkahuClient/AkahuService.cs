using System.Net;
using System.Text;
using System.Text.Json;
using AkahuClient.Configurations;
using AkahuClient.Models.Accounts;
using AkahuClient.Models.Payments;
using AkahuClient.Models.Transfers;

namespace AkahuClient;

public class AkahuService(HttpClient httpClient, AkahuEndpoint endpoint) : IAkahuService
{
    public async Task<AccountResponse> ListAccountsAsync()
    {
        var response = await httpClient.GetAsync(endpoint.Account);
        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            if (e.StatusCode == HttpStatusCode.NotFound)
                // logger.LogWarning("xxx not found with");
                throw;
        }

        var content = await response.Content.ReadAsStringAsync();

        var account = JsonSerializer.Deserialize<AccountResponse>(content, AkahuJsonSerializerConfiguration.Options);

        return account!;
    }

    public async Task<TransferResponse> TransferAsync(Account from, Account to, decimal amount)
    {
        var aTransfer = new
        {
            from = from.Id,
            to = to.Id,
            amount
        };

        var jsonContent = JsonSerializer.Serialize(aTransfer, AkahuJsonSerializerConfiguration.Options);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


        var response = await httpClient.PostAsync(endpoint.Transfer, content);


        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            if (e.StatusCode == HttpStatusCode.NotFound) throw;
        }


        var responseContent = await response.Content.ReadAsStringAsync();
        var transferResponse =
            JsonSerializer.Deserialize<TransferResponse>(responseContent, AkahuJsonSerializerConfiguration.Options);

        return transferResponse!;
    }

    public async Task<PaymentResponse> PayAsync(Account from, Account to, decimal amount)
    {
        var aPayment = new
        {
            from = from.Id,
            to = new
            {
                account_number = to.FormattedAccount,
                name = to.Name
            },
            amount
        };

        var jsonContent = JsonSerializer.Serialize(aPayment, AkahuJsonSerializerConfiguration.Options);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(endpoint.Payment, content);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            if (e.StatusCode == HttpStatusCode.NotFound) throw;
        }

        var responseContent = await response.Content.ReadAsStringAsync();
        var paymentResponse =
            JsonSerializer.Deserialize<PaymentResponse>(responseContent, AkahuJsonSerializerConfiguration.Options);
        return paymentResponse!;
    }
}