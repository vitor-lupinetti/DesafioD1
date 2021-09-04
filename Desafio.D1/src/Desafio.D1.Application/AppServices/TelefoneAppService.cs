using AutoMapper;
using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Application.AppServices
{
    public class TelefoneAppService : ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;
        private readonly IMapper _mapper;
        private readonly IClientesTelefoneService _clientesTelefoneService;

        public TelefoneAppService(ITelefoneService telefoneService, IMapper mapper, IClientesTelefoneService clientesTelefoneService)
        {
            _telefoneService = telefoneService;
            _mapper = mapper;
            _clientesTelefoneService = clientesTelefoneService;
        }

        public async Task Adicionar(TelefoneViewModel telefone, Guid clienteId)
        {
            var tel = await _telefoneService.Adicionar(_mapper.Map<Telefone>(telefone));
            await _clientesTelefoneService.Adicionar(new ClientesTelefone { IdCliente = clienteId, IdTelefone = tel.Id });
        }
    }
}
