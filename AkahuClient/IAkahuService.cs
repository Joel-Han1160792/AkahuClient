using AkahuClient.Models.Accounts;

public interface IAkahuService {
    Task<Account> GetAccountAsync();
}