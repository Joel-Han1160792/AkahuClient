namespace AkahuClient.Models.Accounts.Loans;

public class LoanTerm
{
    /// <summary>
    /// The number of years the loan is for.
    /// </summary>
    public int? Year { get; set; }

    /// <summary>
    /// The number of months the loan is for.
    /// </summary>
    public int? Month { get; set; }
}