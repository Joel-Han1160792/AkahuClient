/// <summary>
/// List of Akahu end point information
/// TODO when Akahu publishes v2 version of endpoint, we can introduce a json configuration and bind it to EndPoint class
/// </summary>
public class Endpoint
{
    public static string Version = "v1";

    public static string Host = "api.akahu.io";

    public static string BaseUrl = "https://api.akahu.io";

    public static string User = BaseUrl + "/" + Version + "/me";

    public static string Account = BaseUrl + "/" + Version + "/accounts";
    
    public static string Transfer = BaseUrl + "/" + Version + "/transfers";
    
    public static string Payment = BaseUrl + "/" + Version + "/payments";
}