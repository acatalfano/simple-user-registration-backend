using System;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace user_registration_backend.Context
{
    public interface IDbContext : IDisposable
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
