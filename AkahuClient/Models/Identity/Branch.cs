namespace AkahuClient.Models.Identity;

/// <summary>
/// Branch details (if available)
/// </summary>
public abstract class Branch
{
    public string? Id { get; set; }
    public string? Description { get; set; }
    public string? Phone { get; set; }
    public BranchAddress? Address { get; set; }
}