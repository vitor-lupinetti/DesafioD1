using Desafio.D1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface IClientesEnderecoService : IDisposable
    {
        Task<ClientesEndereco> Adicionar(ClientesEndereco cliente);
        Task Atualizar(ClientesEndereco cliente);
        Task Remover(Guid id);
    }
}
