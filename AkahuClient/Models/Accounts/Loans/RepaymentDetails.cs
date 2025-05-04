using AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

namespace AkahuClient.Models.Accounts.Loans;

public class RepaymentDetails
{
    /// <summary>
    ///     The frequency of the loan repayment.
    /// </summary>
    public RepaymentFrequency? Frequency { get; set; }

    /// <summary>
    ///     The next repayment date, if available.
    /// </summary>
    public string? NextDate { get; set; }

    /// <summary>
    ///     The next instalment amount.
    /// </summary>
    public decimal NextAmount { get; set; }
}