namespace AkahuClient.Models.Transfers;

/// <summary>
/// Transfer object returned by the /transfers endpoint.
/// </summary>
public class Transfer
{
    public string Id { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public decimal Amount { get; set; }
    public string Sid { get; set; } 
    public TransferStatus Status { get; set; }
    public string? StatusText { get; set; }
    public bool Final { get; set; }
    public List<TransferTimelineEntry> Timeline { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class TransferResponse:AkahuEnvelopeResponse<Transfer>
{
    
}