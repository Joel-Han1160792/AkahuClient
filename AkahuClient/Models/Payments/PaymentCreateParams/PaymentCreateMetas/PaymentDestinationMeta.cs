namespace AkahuClient.Models.Payments.PaymentCreateParams.PaymentCreateMetas;

/// <summary>
///     Metadata for the destination (payee) account.
/// </summary>
public class PaymentDestinationMeta
{
    public string? Particulars { get; set; }
    public string? Code { get; set; }
    public string? Reference { get; set; }
}