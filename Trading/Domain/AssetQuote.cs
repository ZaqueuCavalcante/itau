namespace Itau.Trading.Domain;

/// <summary>
/// Cotação
/// </summary>
public sealed class AssetQuote
{
    public long Id { get; private set; }
    public long AssetId { get; private set; }

    public long UnitPrice { get; private set; }
    public DateTime Timestamp { get; private set; }
}
