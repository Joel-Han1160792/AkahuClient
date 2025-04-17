using AkahuClient.Models.Accounts;

namespace AkahuClient;

public interface IAkahuService
{
    Task<IEnumerable<Account>?> ListAccountsAsync();
}