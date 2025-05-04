namespace AkahuClient.Models.Identity;

public class IdentityVerifyNameQuery
{
    /// <summary>
    ///     The user's given name which will be verified against the Akahu identity result.
    /// </summary>
    public string? GivenName { get; set; }

    /// <summary>
    ///     The user's middle name which will be verified against the Akahu identity result.
    ///     If the user has multiple middle names, provide them all separated by a space.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    ///     The user's family name which will be verified against the Akahu identity result.
    /// </summary>
    public string? FamilyName { get; set; }
}