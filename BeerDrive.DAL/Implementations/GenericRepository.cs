using BeerDrive.DAL.Context;
using BeerDrive.DAL.Basics;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BeerDrive.DAL.Implementations
{
    public class GenericRepository<TEntity> where TEntity : AuditableEntity
    {
        internal BeerDriveContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(BeerDriveContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        #region Create

        public virtual async Task CreateAsync(TEntity entity)
        {
            await Task.FromResult(dbSet.Add(entity));
        }

        #endregion

        #region Read

        public virtual async Task<TEntity> ReadAsync(Guid id)
        {
            //var entity = await dbSet.FindAsync(id);
            //return !entity.DateDeleted.HasValue ? entity : null;

            return await dbSet.FirstOrDefaultAsync(r => r.Id == id && r.DateDeleted == null);
        }

        public virtual async Task<IEnumerable<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(r => !r.DateDeleted.HasValue).Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> ReadAsync()
        {
            return await dbSet.Where(r => !r.DateDeleted.HasValue).ToListAsync();
        }

        #endregion

        #region Update

        public virtual async Task UpdateAsync(Guid id, TEntity entity)
        {
            var existing = await ReadAsync(id);

            if (existing != null)
                context.Entry(existing).CurrentValues.SetValues(entity);
        }

        #endregion

        #region Delete

        public virtual async Task DeleteAsync(Guid id)
        {
            var item = await ReadAsync(id);

            if (item != null)
                dbSet.Remove(item);
        }

        #endregion

        #region Check

        public virtual async Task<bool> CheckAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(r => !r.DateDeleted.HasValue).AnyAsync(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(r => !r.DateDeleted.HasValue).CountAsync(predicate);
        }

        #endregion
    }
}
