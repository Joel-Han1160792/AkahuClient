using AkahuClient;
using AkahuClient.Configurations;
using AkahuClient.Models.Accounts;
using AkahuClient.Models.Accounts.Enums;
using AkahuClientTest.Helper;

namespace AkahuClientTest;

public class AkahuServiceTest
{
    private readonly AkahuEndpoint _endpoint = new(null);
    private IAkahuService _underTest;

    public AkahuServiceTest()
    {
        _underTest = new AkahuService(
            new HttpClientBuilder().Build(),
            _endpoint
        );
    }

    // BDD Test Method Name
    [Fact]
    public async Task WhenGetFromAkahuWihoutToken_ShouldReturnUnauthorisedResponse()
    {
        // Action & Assert
        var result = await Assert.ThrowsAsync<HttpRequestException>(async () =>
        {
            await _underTest.ListAccountsAsync();
        });
        Assert.NotNull(result);
        Assert.Contains("401", result.Message);
    }

    // C# Test Method Name
    [Fact]
    public async Task GetAccountAsync_WithToken_ReturnAccount()
    {
        var httpClient = new HttpClientBuilder()
            .SetBaseAddress(_endpoint.BaseUrl)
            .SetHost(_endpoint.Host)
            // TODO Set up a dev app credential - Not important for now
            .SetAuthToken("")
            .SetXAkahuAppToken("")
            .Build();
        _underTest = new AkahuService(httpClient, _endpoint);
        var result = await _underTest.ListAccountsAsync();
        Assert.NotNull(result);
        Assert.Equal(2, result.Items.Count());
        var firstAccount = result.Items.First();
        Assert.Equal(AccountStatus.Active, firstAccount.Status);
    }


    [Fact]
    public async Task TransferAsync_WithValidData_ShouldReturnSuccess()
    {
        // Arrange
        var httpClient = new HttpClientBuilder()
            .SetBaseAddress(_endpoint.BaseUrl)
            .SetHost(_endpoint.Host)
            .SetAuthToken("")
            .SetXAkahuAppToken("")
            .Build();

        _underTest = new AkahuService(httpClient, _endpoint);
        var accountResult = await _underTest.ListAccountsAsync();
        var fromAccount = new Account { Id = accountResult.Items.First().Id };
        var toAccount = new Account { Id = accountResult.Items.Last().Id };
        var amount = 0.01M;

        // Act
        var result = await _underTest.TransferAsync(fromAccount, toAccount, amount);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.False(result.HasEmptyItem());
        var transfer = result.Item!;
        Assert.Equal(transfer.Amount, amount);
        // Assert.Equal("PENDING_APPROVAL", result.Status.ToString()); 
    }


    [Fact]
    public async Task PaymentAsync_WithValidData_ShouldReturnSuccess()
    {
        // Arrange
        var httpClient = new HttpClientBuilder()
            .SetBaseAddress(_endpoint.BaseUrl)
            .SetHost(_endpoint.Host)
            .SetAuthToken("")
            .SetXAkahuAppToken("")
            .Build();

        _underTest = new AkahuService(httpClient, _endpoint);
        var accountResult = await _underTest.ListAccountsAsync();
        var fromAccount = new Account { Id = accountResult.Items.First().Id };
        var toAccount = new Account { FormattedAccount = "", Name = "" };
        var amount = 0.01M;

        // Act
        var result = await _underTest.PayAsync(fromAccount, toAccount, amount);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        // Assert.False(result.HasEmptyItem());
        // var transfer = result.Item!;
        // Assert.Equal(transfer.Amount, amount);                     
        // Assert.Equal("PENDING_APPROVAL", result.Status.ToString()); 
    }
}
