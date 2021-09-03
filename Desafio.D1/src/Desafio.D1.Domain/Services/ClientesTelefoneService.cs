using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Services
{
    public class ClientesTelefoneService : BaseService, IClientesTelefoneService
    {
        private readonly IClientesTelefoneRepository _clientesTelefoneRepository;
        public ClientesTelefoneService(INotificador notificador, IClientesTelefoneRepository clientesTelefoneRepository) :base(notificador)
        {
            _clientesTelefoneRepository = clientesTelefoneRepository;
        }
        public async Task<ClientesTelefone> Adicionar(ClientesTelefone cliente)
        {
            await _clientesTelefoneRepository.Add(cliente);
            return cliente;
        }

        public async Task Atualizar(ClientesTelefone cliente)
        {
            await _clientesTelefoneRepository.Update(cliente);
        }

        public void Dispose()
        {
            _clientesTelefoneRepository.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _clientesTelefoneRepository.Delete(id);
        }
    }
}
