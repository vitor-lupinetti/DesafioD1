using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity entity);
        void Delete(TEntity entity);
        Task Delete(int id);
    }
}
