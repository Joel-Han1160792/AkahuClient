using System.Net.Http.Headers;

namespace AkahuClientTest.Helper;

// Builder pattern 
public  class HttpClientBuilder
{
    private  HttpClient? _httpClient;

    public HttpClientBuilder()
    {
        _httpClient = new HttpClient();
    }
    
    public HttpClientBuilder SetHost(string hostName)
    {
        var httpClient = _httpClient ?? new HttpClient();
        httpClient.DefaultRequestHeaders.Host = hostName;
        return this;
    }
    
    public  HttpClientBuilder SetBaseAddress(string baseAddress)
    {
        var httpClient = _httpClient ?? new HttpClient();
        httpClient.BaseAddress = new Uri(baseAddress);
        return this;
    }
    
    public  HttpClientBuilder SetXAkahuAppToken(string appToken)
    {
        var httpClient = _httpClient ?? new HttpClient();
        httpClient.DefaultRequestHeaders.Add("X-Akahu-Id", appToken);
        return this;
    }
    
    public  HttpClientBuilder SetAuthToken(string authToken)
    {
        var httpClient = _httpClient ?? new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",authToken);
        return this;
    }
    
    public  HttpClient Build()
    {
        return _httpClient ??= new HttpClient();
    }
}
