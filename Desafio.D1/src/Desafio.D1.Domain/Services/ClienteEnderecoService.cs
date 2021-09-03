using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Services
{
    public class ClienteEnderecoService : BaseService, IClientesEnderecoService
    {
        private readonly IClientesEnderecoRepository _clientesEnderecoRepository;
        public ClienteEnderecoService(INotificador notificador, IClientesEnderecoRepository clientesEnderecoRepository):base(notificador)
        {
            _clientesEnderecoRepository = clientesEnderecoRepository;
        }
        public async Task<ClientesEndereco> Adicionar(ClientesEndereco cliente)
        {
            await _clientesEnderecoRepository.Add(cliente);
            return cliente;
        }

        public async Task Atualizar(ClientesEndereco cliente)
        {
            await _clientesEnderecoRepository.Update(cliente);
        }

        public void Dispose()
        {
            _clientesEnderecoRepository.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _clientesEnderecoRepository.Delete(id);
        }
    }
}
