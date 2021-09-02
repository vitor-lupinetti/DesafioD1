using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        IEnumerable<TEntity> GetWhere(Func<TEntity, bool> predicate);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        Task Delete(int id);

        Task SaveChanges();
    }

}
