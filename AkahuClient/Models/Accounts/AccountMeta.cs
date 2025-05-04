using AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

namespace AkahuClient.Models.Accounts;

public class AccountMeta
{
    /// <summary>
    ///     The account holder name
    /// </summary>
    public string? Holder { get; set; }

    /// <summary>
    ///     Details about a loan account, if available.
    /// </summary>
    public AccountLoanDetail? Name { get; set; }

    /// <summary>
    ///     Catch-all for dynamic attributes.
    /// </summary>
    public Dictionary<string, object>? AdditionalAttributes { get; set; } = new();
}