using System.Runtime.InteropServices.JavaScript;
using AkahuClient.Models.Accounts.Enums;

namespace AkahuClient.Models.Accounts;

public class RepaymentDetails
{
    /**
     * The frequency of the loan repayment.
     */
    public RepaymentFrequency? Frequency { get; set; }
    
    /**
     * The next repayment date, if available.
     */
    public string? NextDate { get; set; }
    
    /**
     * The next instalment amount.
     */
    public decimal NextAmount { get; set; }
}