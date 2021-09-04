using Desafio.D1.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices.Interfaces
{
    public interface IEnderecoAppService
    {
        Task Adicionar(EnderecoViewModel endereco, Guid clienteId);
    }
}
