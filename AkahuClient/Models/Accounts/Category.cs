namespace AkahuClient.Models.Accounts;

/// <summary>
///     Akahu category metadata returned by /categories endpoints.
/// </summary>
public class Category
{
    public string? Id { get; set; }
    public string? Name { get; set; }

    /// <summary>
    ///     A dictionary where the key is a grouping key, and the value is a Group object.
    /// </summary>
    public Dictionary<string, Group>? Groups { get; set; }
}

public class Group
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}