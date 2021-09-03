using AutoMapper;
using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IClientesEnderecoService _clienteEnderecoService;
        private readonly IEnderecoService _enderecoService;
        private readonly ITelefoneService _telefoneService;
        private readonly IClientesTelefoneService _clientesTelefoneService;
        private readonly IMapper _mapper;
        public ClienteAppService(IClienteService clienteService, IMapper mapper, IClientesEnderecoService clientesEnderecoService,
            IEnderecoService enderecoService, ITelefoneService telefoneService, IClientesTelefoneService clientesTelefoneService)
        {
            _clienteService = clienteService;
            _clienteEnderecoService = clientesEnderecoService;
            _enderecoService = enderecoService;
            _telefoneService = telefoneService;
            _clientesTelefoneService = clientesTelefoneService;

            _mapper = mapper;
        }
        public async Task Adicionar(ClienteViewModel cliente)
        {
            var clienteInserted = await _clienteService.Adicionar(_mapper.Map<Cliente>(cliente));
            var endereco = await _enderecoService.Adicionar(_mapper.Map<Endereco>(cliente));
            var telefone = await _telefoneService.Adicionar(_mapper.Map<Telefone>(cliente));
            var clienteEndereco = await _clienteEnderecoService.Adicionar(new ClientesEndereco { IdCliente = clienteInserted.Id, IdEndereco = endereco.Id });
            var clienteTelefone = await _clientesTelefoneService.Adicionar(new ClientesTelefone { IdCliente = clienteInserted.Id, IdTelefone = telefone.Id });
        }

        public Task Atualizar(ClienteViewModel cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<ClienteViewModel> ObterPorId(Guid id)
        {
            return _mapper.Map<ClienteViewModel>(await _clienteService.ObterPorId(id));
        }

        public async Task<IEnumerable<ClienteViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteService.ObterTodos());
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
