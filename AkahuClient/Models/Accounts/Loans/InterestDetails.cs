using AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

namespace AkahuClient.Models.Accounts.Loans;

public class InterestDetails
{
    /// <summary>
    ///     The interest rate on the loan.
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    ///     The type of interest rate.
    /// </summary>
    public InterestType Type { get; set; }

    /// <summary>
    ///     When this interest rate expires, if available.
    /// </summary>
    public string? ExpiresAt { get; set; }
}