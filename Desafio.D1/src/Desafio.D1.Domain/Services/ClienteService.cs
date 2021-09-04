using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(INotificador notificador,IClienteRepository clienteRepository):base(notificador)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<Cliente> Adicionar(Cliente cliente)
        {
            await _clienteRepository.Add(cliente);
            return cliente;
        }

        public async Task Atualizar(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            var cliente = await _clienteRepository.GetById(id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await _clienteRepository.GetAll();
        }

        public async Task Remover(Guid id)
        {
            await _clienteRepository.Delete(id);
        }
    }
}
