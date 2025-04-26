namespace AkahuClient.Models.Payments;

public class PaymentTimeline
{
    public PaymentStatus Status { get; set; }
    public string Time { get; set; }
    public string? Eta { get; set; }
}