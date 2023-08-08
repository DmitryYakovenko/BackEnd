using Domain.Documents;
using Domain.Objects;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IBaseDbContext
    {
        #region Documents
        DbSet<DryerDocument> DryerDocuments { get; set; }
        DbSet<PackingDocument> PackingDocuments { get; set; }
        DbSet<PressDocument> PressDocuments { get; set; }
        DbSet<ShippingDocument> ShippingDocuments { get; set; }
        #endregion

        #region Modes

        #endregion

        #region Objects
        DbSet<Fraction> Fractions { get; set; }
        DbSet<PackingType> PackingTypes { get; set; }
        DbSet<Pellet> Pellets { get; set; }
        #endregion
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
