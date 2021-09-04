using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.D1.UI.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoAppService _enderecoAppService;
        public EnderecosController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }
        // GET: ClientesController/Create
        public ActionResult Create(Guid clienteId)
        {
            EnderecoViewModel end = new EnderecoViewModel();
            end.ClienteId = clienteId;
            return View(end);
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EnderecoViewModel end, Guid clienteId)
        {
            await _enderecoAppService.Adicionar(end, clienteId);
            return View();
        }
    }
}
