namespace AkahuClient.Models.Payments.PaymentQueryParams;

/// <summary>
///     The date range that will be used to filter payment results.
/// </summary>
public class PaymentQueryParams
{
    /// <summary>
    ///     The start date of the query as an ISO 8601 string.
    ///     Default value: 30 days ago.
    /// </summary>
    public string? Start { get; set; }

    /// <summary>
    ///     The end date of the query as an ISO 8601 string.
    ///     Default value: today.
    /// </summary>
    public string? End { get; set; }
}