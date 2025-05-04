namespace AkahuClient.Models.Payments.PaymentCreateParams;

/// <summary>
///     Parameters for initiating a new bank account payment using Akahu.
/// </summary>
public class PaymentCreateParams
{
    /// <summary>
    ///     The Akahu account id from which the payment will be made.
    ///     Must refer to an account linked by the authenticated user.
    ///     (Account ID starts with 'acc_...')
    /// </summary>
    public string From { get; set; }

    /// <summary>
    ///     The dollar amount for the payment. Must have no more than 2 decimal places.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    ///     The payee bank account to which the payment will be made.
    /// </summary>
    public PayeeAccount To { get; set; }

    /// <summary>
    ///     Optional metadata to send with the payment.
    /// </summary>
    public PaymentCreateMeta? Meta { get; set; }
}