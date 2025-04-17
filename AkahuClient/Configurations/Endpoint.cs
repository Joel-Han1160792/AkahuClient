namespace AkahuClient.Configurations;

/// <summary>
///     List of Akahu end point information
///     TODO when Akahu publishes v2 version of endpoint, we can introduce a json configuration and bind it to EndPoint
///     class
/// </summary>
public class Endpoint
{
    private static readonly string Version = "v1";

    public static readonly string Host = "api.akahu.io";

    public static readonly string BaseUrl = "https://api.akahu.io";

    private static string User = BaseUrl + "/" + Version + "/me";

    public static readonly string Account = BaseUrl + "/" + Version + "/accounts";

    private static string Transfer = BaseUrl + "/" + Version + "/transfers";

    private static string Payment = BaseUrl + "/" + Version + "/payments";
}