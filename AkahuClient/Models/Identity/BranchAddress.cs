namespace AkahuClient.Models.Identity;

public class BranchAddress
{
    public string? Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; } = "New Zealand";
    public string? PostalCode { get; set; }
}