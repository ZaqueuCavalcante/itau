using Itau.Trading.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itau.Trading.Database;

public class AssetQuoteConfig : IEntityTypeConfiguration<AssetQuote>
{
    public void Configure(EntityTypeBuilder<AssetQuote> assetQuote)
    {
        assetQuote.ToTable("asset_quotes");

        assetQuote.HasKey(aq => aq.Id);
        assetQuote.Property(aq => aq.Id).ValueGeneratedOnAdd();
    }
}
