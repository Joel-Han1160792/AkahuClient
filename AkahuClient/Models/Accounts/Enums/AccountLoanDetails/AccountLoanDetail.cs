using AkahuClient.Models.Accounts.Enums;
namespace AkahuClient.Models.Accounts.Enums;

public class AccountLoanDetail
{
    /**
    * The purpose of the loan, if we can't determine the purpose, this will be `UNKNOWN`
    */
    public AccountLoanPurpose Purpose { get; set; }
    /**
     * The type of loan, if we can't determine the type, this will be `UNKNOWN`
     */
    public AccountLoanType LoanType { get; set; }
    /**
    * Interest rate information for the loan.
    */
    public InterestDetails Interest { get; set; }
    /**
    * Is the loan currently in an interest only period?
    */
    public bool IsInterestOnly { get; set; }
    /**
     * When the interest only period expires, if available.
     */
    public string? InterestOnlyExpiresAt { get; set; }
    /**
     * The duration/term of the loan for it to be paid to completion from the start date of the loan.
     */
    public LoanTerm? Term { get; set; }
    /**
    * When the loan matures, if available.
    */
    public string? MaturesAt { get; set; }
    /**
     * The loan initial principal amount, this was the original amount borrowed.
     */
    public decimal? InitialPrincipal { get; set; }
    /**
     * Loan repayment information if available.
     */
    public RepaymentDetails? Repayment { get; set; }
    
}