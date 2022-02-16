using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VY.TestApi.Data.Contracts.Repositories;

namespace VY.TestApi.Data.Impl.Repositories
{
    public class BaseRepository<TContext, TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
                                                                                          where TContext : DbContext
    {
        protected TContext Context { get; set; }
        protected DbSet<TEntity> DbSet { get; set;}
        private bool _disposed;

        public BaseRepository(TContext context, DbSet<TEntity> dbSet)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public virtual TEntity GetById(TKey id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return DbSet.Where(predicate).ToList();

            }
            return DbSet.ToList();
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void AddAll(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void DeleteAll(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context?.Dispose();
                }

                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
    }
}
