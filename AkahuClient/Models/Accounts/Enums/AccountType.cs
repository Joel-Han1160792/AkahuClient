using System.ComponentModel;

namespace AkahuClient.Models.Accounts.Enums;

public enum AccountType
{
    [Description("CHECKING")]
    Checking,
    Savings,
    Creditcard,
    Loan,
    Kiwisaver,
    Investment,
    Termdeposite,
    Foreign,
    Tax,
    Rewards,
    Wallet
}