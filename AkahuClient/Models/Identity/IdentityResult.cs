using AkahuClient.Models.Identity.Enum;

namespace AkahuClient.Models.Identity;

/// <summary>
///     The result of an Akahu identity verification request.
/// </summary>
public class IdentityResult
{
    public required string Id { get; set; }
    public IdentityStatus Status { get; set; }
    public string? CreatedAt { get; set; }
    public string? UpdatedAt { get; set; }
    public string? ExpiresAt { get; set; }
    public Dictionary<string, object>? Source { get; set; }
    public List<string>? Error { get; set; }
    public List<Dictionary<string, object>>? Identities { get; set; }
    public List<Dictionary<string, object>>? Addresses { get; set; }
    public List<Dictionary<string, object>>? Accounts { get; set; }
}