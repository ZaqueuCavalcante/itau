using Itau.Trading.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Itau.Trading.Database;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> customer)
    {
        customer.ToTable("customers");

        customer.HasKey(c => c.Id);
        customer.Property(c => c.Id).ValueGeneratedOnAdd();

        customer.HasMany<Position>()
            .WithOne()
            .HasPrincipalKey(c => c.Id)
            .HasForeignKey(p => p.CustomerId);

        customer.HasMany<Trade>()
            .WithOne()
            .HasPrincipalKey(c => c.Id)
            .HasForeignKey(p => p.CustomerId);
    }
}
