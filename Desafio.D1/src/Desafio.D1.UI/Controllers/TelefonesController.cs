using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.D1.UI.Controllers
{
    public class TelefonesController : Controller
    {
        private readonly ITelefoneAppService _telefoneAppService;
        public TelefonesController(ITelefoneAppService telefoneAppService)
        {
            _telefoneAppService = telefoneAppService;
        }
        public ActionResult Create(Guid clienteId)
        {
            TelefoneViewModel tel = new TelefoneViewModel();
            tel.ClienteId = clienteId;
            return View(tel);
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TelefoneViewModel tel, Guid clienteId)
        {
            await _telefoneAppService.Adicionar(tel, clienteId);
            return View();
        }
    }
}
