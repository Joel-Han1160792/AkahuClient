namespace AkahuClient.Models.Accounts;

public class AccountRefreshState
{
    /// <summary>
    /// The ISO 8601 timestamp when the balance was last retrieved
    /// </summary>
    public string? Balance { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when other account metadata was last retrieved (any property apart from balance)
    /// </summary>
    public string? Meta { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when we last checked for and processed any new transactions. This flag may be missing when an account has first connected, as it takes a few seconds for new transactions to be processed.
    /// </summary>
    public string? Transaction { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when we last fetched identity data about the party who has authenticated with the financial institution when connecting this account.
    /// </summary>
    public string? Party { get; set; }
}