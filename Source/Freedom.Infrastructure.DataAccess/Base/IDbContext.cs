using System.Data.Entity;

namespace Freedom.Infrastructure.DataAccess.Base
{
    public interface IDbContext
    {
        IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

    }
}
