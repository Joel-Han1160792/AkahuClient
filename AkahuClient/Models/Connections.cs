using System.Text.Json.Serialization;

namespace AkahuClient.Models;

/// <summary>
///     Akahu connection metadata returned by /connections endpoints.
/// </summary>
public class Connection
{
    [JsonPropertyName("_id")] public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }
}