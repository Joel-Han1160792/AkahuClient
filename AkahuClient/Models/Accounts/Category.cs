namespace AkahuClient.Models.Accounts;
/**
 * Akahu category metadata returned by /categories endpoints.
 */
public class Category
{   public string Id { get; set; }
    public string Name { get; set; }
    /** 
    * A dictionary where the key is a grouping key, and the value is a Group object.
    */ 
    public Dictionary<string, Group> Groups { get; set; } 
}
public class Group
{
    public string Id { get; set; }
    public string Name { get; set; }
}