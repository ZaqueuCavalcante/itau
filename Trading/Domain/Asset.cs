namespace Itau.Trading.Domain;

/// <summary>
/// Ativo
/// </summary>
public sealed class Asset
{
    public long Id { get; private set; }
    public string Code { get; private set; }
    public string Name { get; private set; }

    public Asset(string code, string name)
    {
        Code = code;
        Name = name;
    }
}
