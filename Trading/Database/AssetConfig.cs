using Itau.Trading.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itau.Trading.Database;

public class AssetConfig : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> asset)
    {
        asset.ToTable("assets");

        asset.HasKey(a => a.Id);
        asset.Property(a => a.Id).ValueGeneratedOnAdd();

        asset.HasIndex(a => a.Code).IsUnique();

        asset.HasMany<Position>()
            .WithOne()
            .HasPrincipalKey(a => a.Id)
            .HasForeignKey(p => p.AssetId);

        asset.HasMany<Trade>()
            .WithOne()
            .HasPrincipalKey(a => a.Id)
            .HasForeignKey(p => p.AssetId);

        asset.HasMany<AssetQuote>()
            .WithOne()
            .HasPrincipalKey(a => a.Id)
            .HasForeignKey(aq => aq.AssetId);
    }
}
