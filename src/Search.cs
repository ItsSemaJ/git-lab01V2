namespace MiniShop;

public static class Search
{
    /// <summary>All items whose name contains the qeury (case-insensitive).</summary>
    public static List<Item> FindItems(IEnumerable<Item> items, string query)
    {
        var q = query.ToLowerInvariant();
        return items.Where(i => i.Name.Contains(q)).ToList();
    }
}
