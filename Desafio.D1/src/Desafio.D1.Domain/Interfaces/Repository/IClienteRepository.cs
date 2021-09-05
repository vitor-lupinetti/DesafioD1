using Desafio.D1.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> ObterPorNome(string nome);
    }
}
