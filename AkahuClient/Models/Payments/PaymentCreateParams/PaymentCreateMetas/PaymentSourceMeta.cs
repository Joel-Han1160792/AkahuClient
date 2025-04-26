namespace AkahuClient.Models.Payments.PaymentCreateParams.PaymentCreateMetas;

/// <summary>
/// Metadata for the source (payer) account.
/// </summary>
public class PaymentSourceMeta
{
    public string? Code { get; set; }
    public string? Reference { get; set; }
}
