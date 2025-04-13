using AkahuClient.Models.Accounts;

public interface IAkahuService {
    Task<IEnumerable<Account>> ListAccountsAsync();
}