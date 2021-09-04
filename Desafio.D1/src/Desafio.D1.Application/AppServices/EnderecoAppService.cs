using AutoMapper;
using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices
{
    public class EnderecoAppService : IEnderecoAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IClientesEnderecoService _clienteEnderecoService;
        private readonly IEnderecoService _enderecoService;
        private readonly ITelefoneService _telefoneService;
        private readonly IClientesTelefoneService _clientesTelefoneService;
        private readonly IMapper _mapper;

        public EnderecoAppService(IClienteService clienteService, IMapper mapper, IClientesEnderecoService clientesEnderecoService,
            IEnderecoService enderecoService, ITelefoneService telefoneService, IClientesTelefoneService clientesTelefoneService)
        {
            _clienteService = clienteService;
            _clienteEnderecoService = clientesEnderecoService;
            _enderecoService = enderecoService;
            _telefoneService = telefoneService;
            _clientesTelefoneService = clientesTelefoneService;

            _mapper = mapper;
        }
        public async Task Adicionar(EnderecoViewModel endereco, Guid clienteId)
        {
            var end = await _enderecoService.Adicionar(_mapper.Map<Endereco>(endereco));
            await _clienteEnderecoService.Adicionar(new ClientesEndereco { IdCliente = clienteId, IdEndereco = end.Id });
        }
    }
}
