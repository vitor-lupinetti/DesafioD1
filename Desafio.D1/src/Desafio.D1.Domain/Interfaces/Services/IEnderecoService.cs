using Desafio.D1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface IEnderecoService : IDisposable
    {
        Task<Endereco> Adicionar(Endereco endereco);
        Task<IEnumerable<Endereco>> ObterTodos();
        Task Atualizar(Endereco endereco);
        Task Remover(Guid id);
    }
}
