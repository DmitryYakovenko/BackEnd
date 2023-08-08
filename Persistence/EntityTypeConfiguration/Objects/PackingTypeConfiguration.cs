using Domain.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfiguration.Objects
{
    public class PackingTypeConfiguration : IEntityTypeConfiguration<PackingType>
    {
        public void Configure(EntityTypeBuilder<PackingType> builder)
        {
            builder.HasKey(obj => obj.Id);
            builder.HasIndex(obj => obj.Id).IsUnique();
        }
    }
}
