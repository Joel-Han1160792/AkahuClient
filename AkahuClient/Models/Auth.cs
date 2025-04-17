namespace AkahuClient.Models;

/// <summary>
/// OAuth2 token authorization response.
/// </summary>
public class AuthorizationToken
{
    public string? AccessToken { get; set; }
    public string? TokenType { get; set; }
    public string? Scope { get; set; }
}