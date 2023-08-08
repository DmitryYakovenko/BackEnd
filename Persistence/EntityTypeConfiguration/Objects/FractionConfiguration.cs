using Domain.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfiguration.Objects
{
    public class FractionConfiguration : IEntityTypeConfiguration<Fraction>
    {
        public void Configure(EntityTypeBuilder<Fraction> builder)
        {
            builder.HasKey(obj => obj.Id);
            builder.HasIndex(obj => obj.Id).IsUnique();
        }
    }
}
