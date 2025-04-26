namespace AkahuClient.Models.Payments.IrdPaymentCreateParams;

/// <summary>
/// Parameters for initiating a new payment from a bank account to IRD.
/// </summary>
public class IrdPaymentCreateParams
{
    /// <summary>
    /// The Akahu account id from which the payment will be made.
    /// Must refer to an account linked by the authenticated user (starts with "acc_...").
    /// </summary>
    public string From { get; set; }

    /// <summary>
    /// The dollar amount for the payment. Must have no more than 2 decimal places.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Required tax payment metadata to send with the payment.
    /// </summary>
    public IrdPaymentMeta Meta { get; set; }
}
