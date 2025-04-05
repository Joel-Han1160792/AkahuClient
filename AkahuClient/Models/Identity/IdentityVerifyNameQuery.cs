namespace AkahuClient.Models.Identity;

public class IdentityVerifyNameQuery
{
    /**
   * The user's given name which will be verified against the Akahu identity
   * result.
   */
    public string? GivenName { get; set; }
    /**
  * The user's middle name which will be verified against the Akahu identity
  * result. If the user has multiple middle names, provide them all separated
  * by a space.
  */
    public string? MiddleName { get; set; }
    /**
    * The user's family name which will be verified against the Akahu identity
    * result.
    */
    public string? FamilyName { get; set; }
}