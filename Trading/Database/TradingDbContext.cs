using Itau.Trading.Domain;
using Itau.Trading.Settings;
using Microsoft.EntityFrameworkCore;

namespace Itau.Trading.Database;

public class TradingDbContext(DbContextOptions<TradingDbContext> options, DatabaseSettings settings) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();
        optionsBuilder.UseNpgsql(settings.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("trading");

        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
