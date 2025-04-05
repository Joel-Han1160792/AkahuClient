namespace AkahuClient.Models.Accounts.Enums;

/**
     * The type of loan, if we can't determine the type, this will be `UNKNOWN`
     */
public enum AccountLoanType
{
    Unknown = 0,
    Table,
    Reducing,
    Revolving
}