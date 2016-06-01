using System.Data.Entity.ModelConfiguration;
using Freedom.Domain.Entities;

namespace Freedom.Infrastructure.DataAccess.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.FirstName).HasMaxLength(60).HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LastName).HasMaxLength(60).HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Email).HasMaxLength(100).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Cpf).HasMaxLength(11).HasColumnType("nvarchar");
            Property(x => x.Password).HasMaxLength(64).IsRequired().HasColumnType("nvarchar");
            Property(x => x.Status).HasColumnType("smallint");
            Property(x => x.Created).HasColumnType("DateTime");
            Property(x => x.Modified).HasColumnType("DateTime");
            Property(x => x.GroupId).IsRequired();

            //relationship
            HasRequired(x => x.Group).WithMany().HasForeignKey(u => u.GroupId).WillCascadeOnDelete(false);
        }
    }
}