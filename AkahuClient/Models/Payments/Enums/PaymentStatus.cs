namespace AkahuClient.Models.Payments;

public enum PaymentStatus
{
    Error,
    Ready,
    PendingApproval,
    Paused,
    Sent,
    Declined,
    Cancelled
}