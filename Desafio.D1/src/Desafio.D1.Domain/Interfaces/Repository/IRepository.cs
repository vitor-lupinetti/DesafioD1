using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        IEnumerable<TEntity> GetWhere(Func<TEntity, bool> predicate);
        Task Update(TEntity entity);
        void Delete(TEntity entity);
        Task Delete(Guid id);

        Task SaveChanges();
    }

}
