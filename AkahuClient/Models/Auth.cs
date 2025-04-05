namespace AkahuClient.Models;
/**
 * OAuth2 token authorization response.
 */
public class AuthorizationToken
{
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public string Scope { get; set; }
}

