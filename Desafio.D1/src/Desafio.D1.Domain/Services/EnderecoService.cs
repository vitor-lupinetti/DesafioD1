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
    public class EnderecoService : BaseService, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(INotificador notificador, IEnderecoRepository enderecoRepository):base(notificador)
        {
            _enderecoRepository = enderecoRepository;
        }
        public async Task<Endereco> Adicionar(Endereco endereco)
        {
            endereco.Id = Guid.NewGuid();
            await _enderecoRepository.Add(endereco);
            return endereco;
        }

        public async Task Atualizar(Endereco endereco)
        {
            await _enderecoRepository.Update(endereco);
        }

        public void Dispose()
        {
            _enderecoRepository.Dispose();
        }

        public async Task<IEnumerable<Endereco>> GetAdressesByUserId(Guid id)
        {
            return await _enderecoRepository.GetAdressesByUserId(id);
        }

        public async Task<IEnumerable<Endereco>> ObterTodos()
        {
            return await _enderecoRepository.GetAll();
        }

        public async Task Remover(Guid id)
        {
            await _enderecoRepository.Delete(id);
        }
    }
}
