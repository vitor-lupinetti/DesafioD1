using Desafio.D1.Application.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices.Interfaces
{
    public interface IClienteAppService
    {
        Task Adicionar(ClienteViewModel cliente);
        Task<IEnumerable<ClienteViewModel>> ObterTodos();
        Task<ClienteUpdateViewModel> ObterPorId(Guid id);
        Task Atualizar(ClienteUpdateViewModel cliente);
        Task Remover(Guid id);
    }
}
