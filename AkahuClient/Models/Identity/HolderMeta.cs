namespace AkahuClient.Models.Identity;

/// <summary>
///     Metadata from the matched account
/// </summary>
public class HolderMeta
{
    /// <summary>
    ///     The account name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The account holder name
    /// </summary>
    public string? Holder { get; set; }

    /// <summary>
    ///     Formatted account number
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    ///     The address associated with the account
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    ///     The name of the bank
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    ///     Branch details (if available)
    /// </summary>
    public Branch? Branch { get; set; }
}