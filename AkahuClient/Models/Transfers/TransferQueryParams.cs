namespace AkahuClient.Models.Transfers;

/// <summary>
/// The date range that will be used to filter transfer results.
/// </summary>
public class TransferQueryParams
{
    /// <summary>
    /// The start date of the query as an ISO 8601 string.
    ///
    /// @defaultValue `30 days ago`
    /// </summary>
    public string? Start { get; set; }

    /// <summary>
    /// The end date of the query as an ISO 8601 string.
    ///
    /// @defaultValue `today`
    /// </summary>
    public string? End { get; set; }
}
