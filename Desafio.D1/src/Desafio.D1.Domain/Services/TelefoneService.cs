using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Services
{
    public class TelefoneService : BaseService, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(INotificador notificador, ITelefoneRepository telefoneRepository):base(notificador)
        {
            _telefoneRepository = telefoneRepository;
        }
        public async Task<Telefone> Adicionar(Telefone telefone)
        {
            telefone.Id = Guid.NewGuid();
            await _telefoneRepository.Add(telefone);
            return telefone;
        }

        public async Task Atualizar(Telefone telefone)
        {
            await _telefoneRepository.Update(telefone);
        }

        public void Dispose()
        {
            _telefoneRepository.Dispose();
        }

        public async Task<IEnumerable<Telefone>> ObterTodos()
        {
            return await _telefoneRepository.GetAll();
        }

        public async Task Remover(Guid id)
        {
            await _telefoneRepository.Delete(id);
        }
    }
}
