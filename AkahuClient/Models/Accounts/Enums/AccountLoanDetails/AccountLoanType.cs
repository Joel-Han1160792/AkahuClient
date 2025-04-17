namespace AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

/// <summary>
/// The type of loan, if we can't determine the type, this will be `UNKNOWN`
/// </summary>
public enum AccountLoanType
{
    Unknown = 0,
    Table,
    Reducing,
    Revolving
}