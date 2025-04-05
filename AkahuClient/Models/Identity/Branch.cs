namespace AkahuClient.Models.Identity;

/** Branch details (if available) */
public class Branch
{
    public string Id { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public BranchAddress Address { get; set; }
}