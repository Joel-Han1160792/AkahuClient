using AkahuClient.Models.Identity.Enum;

namespace AkahuClient.Models.Identity;

public class AccountHolderNameVerificationSource
{
    public NameVerificationSourceType Type { get; set; } = NameVerificationSourceType.HolderName;
    public MatchResult MatchResult { get; set; }
    public HolderMeta? Meta { get; set; }
    public NameVerification? Verification { get; set; }
}