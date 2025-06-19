namespace Itau.Trading.Domain;

/// <summary>
/// Posição
/// </summary>
public sealed class Position
{
    public long Id { get; private set; }
    public long CustomerId { get; private set; }
    public long AssetId { get; private set; }

    public long Quantity { get; private set; }
    public long AveragePrice { get; private set; }

    public decimal ProfitLoss { get; private set; }
}
