namespace Itau.Trading.Domain;

/// <summary>
/// Operação
/// </summary>
public sealed class Trade
{
    public long Id { get; private set; }
    public long CustomerId { get; private set; }
    public long AssetId { get; private set; }

    public TradeType Type { get; private set; }
    public long Quantity { get; private set; }
    public long UnitPrice { get; private set; }
    public long BrokerFee { get; private set; }

    public DateTime Timestamp { get; private set; }
}
