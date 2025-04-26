using AkahuClient.Models.Payments.PaymentCreateParams.PaymentCreateMetas;

namespace AkahuClient.Models.Payments.PaymentCreateParams;

/// <summary>
/// Optional metadata sent with the payment.
/// </summary>
public class PaymentCreateMeta
{
    /// <summary>
    /// Metadata appearing on the payer's account statement.
    /// Note: 'particulars' is not allowed here.
    /// </summary>
    public PaymentSourceMeta? Source { get; set; }

    /// <summary>
    /// Metadata appearing on the payee's account statement.
    /// </summary>
    public PaymentDestinationMeta? Destination { get; set; }
}
