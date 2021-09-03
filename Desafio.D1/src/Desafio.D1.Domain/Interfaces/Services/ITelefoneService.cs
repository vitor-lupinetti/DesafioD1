using Desafio.D1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface ITelefoneService : IDisposable
    {
        Task<Telefone> Adicionar(Telefone telefone);
        Task<IEnumerable<Telefone>> ObterTodos();
        Task Atualizar(Telefone telefone);
        Task Remover(Guid id);
    }
}
