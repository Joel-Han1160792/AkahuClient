namespace AkahuClient.Models.Payments.IrdPaymentCreateParams;

/// <summary>
///     Metadata required for an IRD payment.
/// </summary>
public class IrdPaymentMeta
{
    /// <summary>
    ///     The IRD/GST number associated with the payment.
    /// </summary>
    public string TaxNumber { get; set; }

    /// <summary>
    ///     The 3 character IRD tax type code that tells IRD what type of tax the payment is for.
    ///     See: https://www.ird.govt.nz/managing-my-tax/make-a-payment/choosing-the-right-account-type
    /// </summary>
    public string TaxType { get; set; }

    /// <summary>
    ///     The end date of the tax period which this payment is for, formatted as an ISO 8601 date (e.g. 1970-01-01).
    ///     This is required for most tax payments. Certain payment types like ARR, KSS, LGL may not require it.
    ///     See: https://www.ird.govt.nz/managing-my-tax/make-a-payment/ways-of-paying/paying-electronically
    /// </summary>
    public string? TaxPeriod { get; set; }
}