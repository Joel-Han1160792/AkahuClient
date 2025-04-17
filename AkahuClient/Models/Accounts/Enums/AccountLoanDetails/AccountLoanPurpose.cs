namespace AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

/// <summary>
/// The purpose of the loan, if we can't determine the purpose, this will be `UNKNOWN`
/// </summary>
public enum AccountLoanPurpose
{
    Unknown = 0,
    Home,
    Personal,
    Business
}