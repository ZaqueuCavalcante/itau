using Itau.Trading.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itau.Trading.Database;

public class PositionConfig : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> position)
    {
        position.ToTable("positions");

        position.HasKey(p => p.Id);
        position.Property(p => p.Id).ValueGeneratedOnAdd();
    }
}
