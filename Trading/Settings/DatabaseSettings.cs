namespace Itau.Trading.Settings;

public class DatabaseSettings
{
    public required string ConnectionString { get; set; }

    public DatabaseSettings(IConfiguration configuration)
    {
        configuration.GetSection("Database").Bind(this);
    }
}
