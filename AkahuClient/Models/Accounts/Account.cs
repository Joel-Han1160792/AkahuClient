using System.Text.Json.Serialization;
using AkahuClient.Models.Accounts.Enums;

namespace AkahuClient.Models.Accounts;

public class Account
{
    /// <summary>
    ///     A unique identifier for the account in the Akahu system.
    ///     It is always prefixed by `acc_` so that you can tell that it belongs to an account.
    /// </summary>
    [JsonPropertyName("_id")]
    public string? Id { get; set; }

    /// <summary>
    ///     This tells you whether Akahu can currently sign in to the account to refresh its data.
    ///     It can be one of:
    ///     - ACTIVE: Akahu can sign in and refresh this account.
    ///     - INACTIVE: Akahu no longer has access to this account.
    /// </summary>
    [JsonPropertyName("status")]
    public AccountStatus Status { get; set; }

    /// <summary>
    ///     The credentials key used to group accounts created in the same login session.
    ///     Always prefixed with `creds_`.
    /// </summary>
    [JsonPropertyName("_credentials")]
    public string? Credentials { get; set; }

    /// <summary>
    ///     Information about the financial institution where the account is held (e.g., ANZ bank).
    /// </summary>
    [JsonPropertyName("connection")]
    public Connection? Connections { get; set; }

    /// <summary>
    ///     Standardized account number format, e.g., bank account or credit card (partially masked).
    /// </summary>
    [JsonPropertyName("formatted_account")]
    public string? FormattedAccount { get; set; }

    /// <summary>
    ///     The type of account. Akahu provides specific and fallback account types:
    ///     - CHECKING, SAVINGS, CREDITCARD, LOAN, KIWISAVER, INVESTMENT, TERMDEPOSIT,
    ///     FOREIGN, TAX, REWARDS, WALLET
    /// </summary>
    [JsonPropertyName("type")]
    public AccountType Type { get; set; }

    /// <summary>
    ///     The list of attributes indicates the account's abilities:
    ///     - TRANSACTIONS, TRANSFER_TO, TRANSFER_FROM, PAYMENT_TO, PAYMENT_FROM
    /// </summary>
    [JsonPropertyName("attributes")]
    public List<AccountAttribute>? Attributes { get; set; }

    /// <summary>
    ///     The current and available balance, credit limit, and overdraft info.
    /// </summary>
    [JsonPropertyName("balance")]
    public AccountBalance? Balance { get; set; }

    /// <summary>
    ///     Timestamped info about the last successful data refreshes for this account.
    /// </summary>
    [JsonPropertyName("refreshed")]
    public AccountRefreshState? Refreshed { get; set; }

    /// <summary>
    ///     Metadata regarding the account, e.g., account holder name.
    /// </summary>
    [JsonPropertyName("meta")]
    public AccountMeta? Meta { get; set; }

    /// <summary>
    ///     The name of the account, either custom or fallback to the product name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}