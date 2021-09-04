using Desafio.D1.Application.ViewModels;
using System;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices.Interfaces
{
    public interface ITelefoneAppService
    {
        Task Adicionar(TelefoneViewModel telefone, Guid clienteId);
    }
}
