namespace AkahuClient.Models;

/// <summary>
/// A "page" of results returned by paginated API endpoints.
/// </summary>
public class Paginated<T>
{
    /// <summary>
    /// Each page contains an array of zero-or-more returned objects nested under the
    /// `items` key. In some cases - even if the returned `items` array is empty -
    /// there may still be further pages available. Because if this it is important
    /// to always check the value of `cursor.next` in the response.
    /// </summary>
    public List<T>? Items { get; set; }

    /// <summary>
    /// The cursor pointing to the next page of results can be found nested under
    /// `cursor.next`. If there are no further results available, `cursor.next` will be `null`.
    /// </summary>
    public Cursor? Cursor { get; set; }
}

/// <summary>
///     Represents a pagination cursor pointing to the next page.
/// </summary>
public class Cursor
{
    public string? Next { get; set; }
}

/// <summary>
/// Additional options for a POST request
/// </summary>
public class PostRequestOptions
{
    public string? IdempotencyKey { get; set; }
}

public class AkahuEnvelopeResponse<T>
{
    public bool Success { get; set; }
    public IEnumerable<T>? Items { get; set; }
    
    public bool HasEmptyItem()
    {
        return Items is null
               || !Items.Any()
               || !Success;
    }
}