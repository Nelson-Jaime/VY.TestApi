using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.TestApi.Data.Contracts.Repositories
{
    public interface IWriteRepository<in TEntity, in TKey> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void AddAll(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteAll(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        Task SaveChanges();
    }
}
