using AkahuClient.Models.Identity.Enum;

namespace AkahuClient.Models.Identity;

public class PartyMeta
{
    public PartyMetaType Type { get; set; }
    public string? Initials { get; set; }
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
    public string? FullName { get; set; }
    public string? Prefix { get; set; }
    public string? Gender { get; set; }
}