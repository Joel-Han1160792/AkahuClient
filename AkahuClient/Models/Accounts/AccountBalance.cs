using System.Text.Json.Serialization;
using AkahuClient.Models.Commons.Enums;

namespace AkahuClient.Models.Accounts;

public class AccountBalance
{
    /// <summary>The currency of the balance (3-letter ISO code).</summary>
    [JsonPropertyName("currency")]
    public Currency Currency { get; set; }

    /// <summary>The current account balance.</summary>
    [JsonPropertyName("current")]
    public decimal Current { get; set; }

    /// <summary>The available balance to spend or withdraw.</summary>
    [JsonPropertyName("available")]
    public decimal? Available { get; set; }

    /// <summary>The credit/overdraft limit.</summary>
    [JsonPropertyName("limit")]
    public decimal? Limit { get; set; }

    /// <summary>Whether the account is in unarranged overdraft.</summary>
    [JsonPropertyName("overdrawn")]
    public bool? Overdrawn { get; set; }
}