using System.Text.Json.Serialization;

namespace AkahuClient.Models.Accounts;

public class AccountResponse
{
    public bool Success { get; set; }
    public IEnumerable<Account> Items { get; set; }
}