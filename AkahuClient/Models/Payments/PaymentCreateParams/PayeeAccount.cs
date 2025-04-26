namespace AkahuClient.Models.Payments.PaymentCreateParams;

/// <summary>
/// Payee bank account details.
/// </summary>
public class PayeeAccount
{
    /// <summary>
    /// The payee account holder name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The full payee account number.
    /// </summary>
    public string AccountNumber { get; set; }
}
