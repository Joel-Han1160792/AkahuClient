using AkahuClient.Models.Identity.Enum;

namespace AkahuClient.Models.Identity;

public class PartyNameVerificationSource
{
    public NameVerificationSourceType Type { get; set; } = NameVerificationSourceType.PartyName;
    public MatchResult MatchResult { get; set; }
    public PartyMeta? Meta { get; set; }
    public NameVerification? Verification { get; set; }
}