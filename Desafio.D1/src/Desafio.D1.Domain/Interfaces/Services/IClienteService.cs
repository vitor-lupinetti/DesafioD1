using Desafio.D1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Task<Cliente> Adicionar(Cliente cliente);
        Task<IEnumerable<Cliente>> ObterTodos();
        Task<Cliente> ObterPorId(Guid id);
        IEnumerable<Cliente> ObterPorNome(string nome);
        Task Atualizar(Cliente cliente);
        Task Remover(Guid id);
    }
}
