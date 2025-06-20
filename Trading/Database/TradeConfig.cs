using Itau.Trading.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itau.Trading.Database;

public class TradeConfig : IEntityTypeConfiguration<Trade>
{
    public void Configure(EntityTypeBuilder<Trade> trade)
    {
        trade.ToTable("trades");

        trade.HasKey(t => t.Id);
        trade.Property(t => t.Id).ValueGeneratedOnAdd();
    }
}
