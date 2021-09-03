using Desafio.D1.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface IClientesTelefoneService : IDisposable
    {
        Task<ClientesTelefone> Adicionar(ClientesTelefone cliente);
        Task Atualizar(ClientesTelefone cliente);
        Task Remover(Guid id);
    }
}
