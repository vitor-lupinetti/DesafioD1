using Desafio.D1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Repository
{
    public interface ITelefoneRepository : IRepository<Telefone>
    {
        Task<IEnumerable<Telefone>> GetPhonesByUserId(Guid id);
    }
}
