using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;

namespace AkahuClient.Configurations;

public class AkahuEndpoint(AkahuEndpointConfiguration? configuration)
{
    private AkahuEndpointConfiguration Configuration { get; } = configuration ?? new AkahuEndpointConfiguration();

    public string BaseUrl => Configuration.Baseurl;
    public string Host => Configuration.Host;
    public string Version => Configuration.Version;
    public string User => $"{Configuration.Baseurl}{Configuration.Version}{Configuration.Resource.User}";
    public string Account => $"{Configuration.Baseurl}{Configuration.Version}{Configuration.Resource.Account}";
    public string Transfer => $"{Configuration.Baseurl}{Configuration.Version}{Configuration.Resource.Transfer}";
    public string Payment => $"{Configuration.Baseurl}{Configuration.Version}{Configuration.Resource.Payment}";

}