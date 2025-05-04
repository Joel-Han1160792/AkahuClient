namespace AkahuClient.Models.Payments;

/// <summary>
///     Payment object returned by the /payments endpoint.
/// </summary>
public class Payment
{
    public string Id { get; set; }

    public string From { get; set; }

    public ToAccount To { get; set; }

    public decimal Amount { get; set; }

    public PaymentMeta Meta { get; set; }

    public string Sid { get; set; }

    public PaymentStatus Status { get; set; }

    public PaymentStatusCode? StatusCode { get; set; }

    public string? StatusText { get; set; }

    public ApprovalType? ApprovalType { get; set; }

    public bool Final { get; set; }

    public List<PaymentTimeline> TimeLine { get; set; }

    public string CreatedAt { get; set; }

    public string UpdatedAt { get; set; }

    public string? ReceivedAt { get; set; }
}