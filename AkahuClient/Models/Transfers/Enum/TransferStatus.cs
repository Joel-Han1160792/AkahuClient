namespace AkahuClient.Models.Transfers;

/// <summary>
///     Transfer status
/// </summary>
public enum TransferStatus
{
    Error,
    Ready,
    PendingApproval,
    Sent,
    Declined,
    Paused,
    Canceled
}