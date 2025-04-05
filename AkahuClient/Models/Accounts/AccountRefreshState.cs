namespace AkahuClient.Models.Accounts;

public class AccountRefreshState
{
    /**
     * The ISO 8601 timestamp when the balance was last retrieved
     */
    public string? Balance { get; set; }
    /**
     * The ISO 8601 timestamp when other account metadata was last retrieved (any property apart from balance)
     */
    public string? Meta  { get; set; }
    /**
     * The ISO 8601 timestamp when we last checked for and processed any new transactions. This flag may be missing when an account has first connected, as it takes a few seconds for new transactions to be processed.
     */
    public string? Transaction { get; set; }
    /**
     * The ISO 8601 timestamp when we last fetched identity data about the party who has authenticated with the financial institution when connecting this account.
     */
    public string? Party { get; set; }
}