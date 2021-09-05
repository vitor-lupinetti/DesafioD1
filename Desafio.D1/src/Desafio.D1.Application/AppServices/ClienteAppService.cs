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

        public async Task Atualizar(ClienteUpdateViewModel cliente)
        {
            await _clienteService.Atualizar(_mapper.Map<Cliente>(cliente));
        }

        public async Task<ClienteUpdateViewModel> ObterPorId(Guid id)
        {
            var cliente = _mapper.Map<ClienteUpdateViewModel>(await _clienteService.ObterPorId(id));
            cliente.Enderecos = _mapper.Map<IEnumerable<EnderecoViewModel>>(await _enderecoService.GetAdressesByUserId(id));
            cliente.Telefones = _mapper.Map<IEnumerable<TelefoneViewModel>>(await _telefoneService.GetPhonesByUserId(id));

            return cliente;
        }

        public IEnumerable<ClienteViewModel> ObterPorNome(string nome)
        {
            var clientes = _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteService.ObterPorNome(nome));

            return clientes;
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
