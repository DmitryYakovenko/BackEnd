using Application.Interfaces;
using Domain.Documents;
using Domain.Objects;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfiguration.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class BaseDbContext : DbContext, IBaseDbContext
    {
        #region Documents
        public DbSet<DryerDocument> DryerDocuments { get; set; }
        public DbSet<PackingDocument> PackingDocuments { get; set; }
        public DbSet<PressDocument> PressDocuments { get; set; }
        public DbSet<ShippingDocument> ShippingDocuments { get; set; }
        #endregion

        #region Modes

        #endregion

        #region Objects
        public DbSet<Fraction> Fractions { get; set; }
        public DbSet<PackingType> PackingTypes { get; set; }
        public DbSet<Pellet> Pellets { get; set; }
        #endregion

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PelletConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
