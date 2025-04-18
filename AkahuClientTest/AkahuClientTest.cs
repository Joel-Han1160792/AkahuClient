using AkahuClient;
using AkahuClient.Configurations;
using AkahuClient.Models.Accounts.Enums;
using AkahuClientTest.Helper;

namespace AkahuClientTest;

public class AkahuServiceTest
{
    private IAkahuService _underTest;

    private AkahuEndpoint _endpoint = new AkahuEndpoint(null);

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
            .SetAuthToken("user_token_clxlwmm5q000208l87s4183yc")
            .SetXAkahuAppToken("app_token_clxlwmm5q000108l8blic6nzx")
            .Build();
        _underTest = new AkahuService(httpClient, _endpoint);
        var result = await _underTest.ListAccountsAsync();
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        var firstAccount = result.First();
        Assert.Equal(AccountStatus.Active, firstAccount.Status);
    }
}

// Reflection
// C# -> Assembly code -> 01010101
// [Fact] -> Assembly code (Fact:JustATest) -> 010101010
// xUnit starts up, first loads everything with [Fact]/[Theory]
//    -> Okay, there is one test: JustATest
//.   -> But JustATest is in AkahuServiceTest class
//.   -> Initiate AkahuServiceTest class
//.   -> Then run AkahuServiceTest.JustATest
//       -> Assert.True(true);