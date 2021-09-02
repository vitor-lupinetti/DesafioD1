using Desafio.D1.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.D1.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal readonly DbSet<TEntity> _dbSet;
        internal readonly DesafioD1Context _context;
        public Repository(DesafioD1Context context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }
        public virtual async Task Add(TEntity entity)
        {
             _dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual async Task Delete(int id)
        {
            Delete(await GetById(id));
            await SaveChanges();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual IEnumerable<TEntity> GetWhere(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public virtual async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }

}
