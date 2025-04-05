using AkahuClient.Models.General.Enums;

namespace AkahuClient.Models.Accounts;

public class AccountBalance
{
    /// <summary>
    /// The current account balance.
    /// </summary>
    private decimal _current;

    /// <summary>
    /// The (3 letter ISO 4217 currency code)[https://www.xe.com/iso4217.php] that this balance is in.
    /// </summary>
    private Currency _currency;
    
    /// <summary>
    /// The balance that is currently available to the account holder
    /// </summary>
    private decimal? _available;
    
    /// <summary>
    /// The credit limit for this account.
    /// For example a credit card limit or an overdraft limit.
    /// This value is only present when provided directly by the connected financial institution.
    /// </summary>
    private decimal? _limit;

    /// <summary>
    /// A boolean indicating whether this account is in unarranged overdraft.
    /// </summary>
    private bool? _overdrawn;
}
//property是否需要，如果需要是否应该使用默认的