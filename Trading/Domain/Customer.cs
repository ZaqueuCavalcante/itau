namespace Itau.Trading.Domain;

public sealed class Customer
{
    public long Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    /// <summary>
    /// Percentual de Corretagem que o Cliente paga pra Corretora Itaú por intermediar a operação <br/>
    /// Exemplo: operação de compra de 4 ações com preço unitário R$ 2.50 e Percentual de Corretagem 0.50% <br/>
    /// Uma operação total de R$ 10.00 onde o Itaú recebe 0.50% -> R$ 0.05
    /// </summary>
    public decimal BrokerPercentage { get; private set; }
}
