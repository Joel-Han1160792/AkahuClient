namespace AkahuClient.Models.Transfers;


/// <summary>
/// Transfer status
/// </summary>
public enum TransferStatus
{
    ERROR,
    READY,
    PENDING_APPROVAL,
    SENT,
    DECLINED,
    PAUSED,
    CANCELLED
}