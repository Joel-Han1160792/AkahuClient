namespace AkahuClient.Models.Identity;
/** Metadata from the matched account */
public class HolderMeta
{
    /** The account name */
    public string Name { get; set; }
    /** The account holder name */
    public string Holder { get; set; }
    /** Formatted account number */
    public string AccountNumber { get; set; }
    /** The address associated with the account */
    public string? Address { get; set; }
    /** The name of the bank */
    public string Bank { get; set; }
    /** Branch details (if available) */
    public Branch? Branch { get; set; }
}