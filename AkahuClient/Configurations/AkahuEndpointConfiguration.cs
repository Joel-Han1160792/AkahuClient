namespace AkahuClient.Configurations;

/// <summary>
///     Akahu end point information
/// </summary>
public class AkahuEndpointConfiguration
{
    public string Version { get; set; } = "/v1";
    public string Host { get; set; } = "api.akahu.io";
    public string Baseurl { get; set; } = "https://api.akahu.io";
    public AkahuResource Resource { get; set; } = new();
}

public class AkahuResource
{
    public string User { get; set; } = "/me";
    public string Account { get; set; } = "/accounts";
    public string Transfer { get; set; } = "/transfers";
    public string Payment { get; set; } = "/payments";
}