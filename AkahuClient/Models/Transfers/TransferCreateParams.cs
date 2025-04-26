namespace AkahuClient.Models.Transfers;

/// <summary>
/// Parameters for initiating a new bank account transfer using Akahu.
/// </summary>
public class TransferCreateParams
{
    /// <summary>
    /// The Akahu account id from which the transfer will be made. The `from`
    /// account id **must** refer to an account that has been linked by the user
    /// for which this request is authenticated.
    ///
    /// An account id starts with `acc_...`.
    /// </summary>
    public string From { get; set; }

    /// <summary>
    /// The Akahu account id to which the transfer will be made. The `to`
    /// account id **must** refer to an account that has been linked by the user
    /// for which this request is authenticated.
    ///
    /// An account id starts with `acc_...`.
    /// </summary>
    public string To { get; set; }

    /// <summary>
    /// The dollar amount for the transfer. This must be a numeric value with no more
    /// than 2 decimal places.
    /// </summary>
    public decimal Amount { get; set; }
}
