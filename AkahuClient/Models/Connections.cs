namespace AkahuClient.Models;
/**
 * Akahu connection metadata returned by /connections endpoints.
 */
public class Connection
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string logo { get; set; }
}
