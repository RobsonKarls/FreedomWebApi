using Freedom.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Freedom.Infrastructure.DataAccess.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Created).HasColumnType("DateTime");
            Property(x => x.Modified).HasColumnType("DateTime");
            Property(x => x.CategoryId).IsRequired();
            Property(x => x.FarmId).IsRequired();

            //relationship BelongsTo
            HasRequired(x => x.Farm).WithMany().HasForeignKey(u => u.FarmId).WillCascadeOnDelete(false);
            HasRequired(x => x.Category).WithMany().HasForeignKey(u => u.CategoryId).WillCascadeOnDelete(false);

        }
    }
}
