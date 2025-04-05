using System.Runtime.InteropServices.JavaScript;
using AkahuClient.Models.Accounts.Enums;

namespace AkahuClient.Models.Accounts;

public class AccountMeta
{
    /**
     * The account holder name
     */
    public string? Holder { get; set; }
    /**
     * Details about a loan account, if available.
     */
    public AccountLoanDetail? Name { get; set; }
    /**
     * Catch-all for dynamic attributes.
     */
    public Dictionary<string, object>? AdditionalAttributes { get; set; }
    
    public AccountMeta()
    {
        AdditionalAttributes = new Dictionary<string, object>();
    }
}