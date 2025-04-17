using AkahuClient.Models.Accounts.Loans;

namespace AkahuClient.Models.Accounts.Enums.AccountLoanDetails;

public class AccountLoanDetail
{
    /// <summary>
    /// The purpose of the loan, if we can't determine the purpose, this will be `UNKNOWN`
    /// </summary>
    public AccountLoanPurpose Purpose { get; set; }

    /// <summary>
    /// The type of loan, if we can't determine the type, this will be `UNKNOWN`
    /// </summary>
    public AccountLoanType LoanType { get; set; }

    /// <summary>
    /// Interest rate information for the loan.
    /// </summary>
    public InterestDetails? Interest { get; set; }

    /// <summary>
    /// Is the loan currently in an interest only period?
    /// </summary>
    public bool IsInterestOnly { get; set; }

    /// <summary>
    /// When the interest only period expires, if available.
    /// </summary>
    public string? InterestOnlyExpiresAt { get; set; }

    /// <summary>
    /// The duration/term of the loan for it to be paid to completion from the start date of the loan.
    /// </summary>
    public LoanTerm? Term { get; set; }

    /// <summary>
    /// When the loan matures, if available.
    /// </summary>
    public string? MaturesAt { get; set; }

    /// <summary>
    /// The loan initial principal amount, this was the original amount borrowed.
    /// </summary>
    public decimal? InitialPrincipal { get; set; }

    /// <summary>
    /// Loan repayment information if available.
    /// </summary>
    public RepaymentDetails? Repayment { get; set; }
}