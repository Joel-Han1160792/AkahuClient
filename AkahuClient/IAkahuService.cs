using AkahuClient.Models.Accounts;
using AkahuClient.Models.Transfers;

namespace AkahuClient;

public interface IAkahuService
{
    #region Account
    Task<AccountResponse> ListAccountsAsync();
    #endregion
    
    #region Payment
    // Task<PaymentResponse> PaymentAsync(from, to, amount);
    #endregion
    
    #region Transfer

    Task<TransferResponse> TransferAsync(
        Account from, 
        Account to, 
        decimal amount);

    #endregion
}