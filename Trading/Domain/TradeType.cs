using System.ComponentModel;

namespace Itau.Trading.Domain;

/// <summary>
/// Tipo de Operação
/// </summary>
public enum TradeType
{
    [Description("Compra")]
    Buy = 0,

    [Description("Venda")]
    Sell = 1,
}
