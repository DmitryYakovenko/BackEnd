using Domain.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfiguration.Objects
{
    public class PelletConfiguration : IEntityTypeConfiguration<Pellet>
    {
        public void Configure(EntityTypeBuilder<Pellet> builder)
        {
            builder.HasKey(obj => obj.Id);
            builder.HasIndex(obj => obj.Id).IsUnique();
        }
    }
}
